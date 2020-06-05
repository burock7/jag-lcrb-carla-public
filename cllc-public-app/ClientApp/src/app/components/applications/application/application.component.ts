
import { filter, takeWhile, catchError, mergeMap, delay } from 'rxjs/operators';
import { Component, OnInit, ViewChild, ChangeDetectionStrategy, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Store } from '@ngrx/store';
import { AppState } from '@app/app-state/models/app-state';
import { Subscription, Subject, Observable, forkJoin, of } from 'rxjs';
import { MatSnackBar, MatDialog } from '@angular/material';
import * as currentApplicationActions from '@app/app-state/actions/current-application.action';
import { ActivatedRoute, Router } from '@angular/router';
import { ApplicationDataService } from '@services/application-data.service';
import { PaymentDataService } from '@services/payment-data.service';
import { Application } from '@models/application.model';
import { FormBase, CanadaPostalRegex } from '@shared/form-base';
import { DynamicsDataService } from '@services/dynamics-data.service';
import { Account, TransferAccount } from '@models/account.model';
import { ApplicationTypeNames, FormControlState } from '@models/application-type.model';
import { TiedHouseConnection } from '@models/tied-house-connection.model';
import { TiedHouseConnectionsDataService } from '@services/tied-house-connections-data.service';
import { EstablishmentWatchWordsService } from '@services/establishment-watch-words.service';
import { KeyValue } from '@angular/common';
import { FeatureFlagService } from '@services/feature-flag.service';
import { FileUploaderComponent } from '@shared/components/file-uploader/file-uploader.component';
import { ConnectionToNonMedicalStoresComponent } from '@components/account-profile/tabs/connection-to-non-medical-stores/connection-to-non-medical-stores.component';
import { UPLOAD_FILES_MODE } from '@components/licences/licences.component';
import { ApplicationCancellationDialogComponent } from '@components/dashboard/applications-and-licences/applications-and-licences.component';
import { AccountDataService } from '@services/account-data.service';
//import { User } from '@models/user.model';
import { DynamicsForm } from '../../../models/dynamics-form.model';
import { DynamicsFormDataService } from '../../../services/dynamics-form-data.service';

const ServiceHours = [
  // '00:00', '00:15', '00:30', '00:45', '01:00', '01:15', '01:30', '01:45', '02:00', '02:15', '02:30', '02:45', '03:00',
  // '03:15', '03:30', '03:45', '04:00', '04:15', '04:30', '04:45', '05:00', '05:15', '05:30', '05:45', '06:00', '06:15',
  // '06:30', '06:45', '07:00', '07:15', '07:30', '07:45', '08:00', '08:15', '08:30', '08:45',
  '09:00', '09:15', '09:30',
  '09:45', '10:00', '10:15', '10:30', '10:45', '11:00', '11:15', '11:30', '11:45', '12:00', '12:15', '12:30', '12:45',
  '13:00', '13:15', '13:30', '13:45', '14:00', '14:15', '14:30', '14:45', '15:00', '15:15', '15:30', '15:45', '16:00',
  '16:15', '16:30', '16:45', '17:00', '17:15', '17:30', '17:45', '18:00', '18:15', '18:30', '18:45', '19:00', '19:15',
  '19:30', '19:45', '20:00', '20:15', '20:30', '20:45', '21:00', '21:15', '21:30', '21:45', '22:00', '22:15', '22:30',
  '22:45', '23:00'
  // , '23:15', '23:30', '23:45'
];


export class ApplicationHTMLContent {
  title: string;
  preamble: string;
  beforeStarting: string;
  nextSteps: string;
}

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ApplicationComponent extends FormBase implements OnInit {
  establishmentWatchWords: KeyValue<string, boolean>[];
  application: Application;
  @Input() skipPayment: boolean = false;
  @Output() saveComplete: EventEmitter<boolean> = new EventEmitter<boolean>();
  @ViewChild('mainForm', { static: false }) mainForm: FileUploaderComponent;
  @ViewChild('financialIntegrityDocuments', { static: false }) financialIntegrityDocuments: FileUploaderComponent;
  @ViewChild('supportingDocuments', { static: false }) supportingDocuments: FileUploaderComponent;
  @ViewChild(ConnectionToNonMedicalStoresComponent, { static: false }) connectionsToProducers: ConnectionToNonMedicalStoresComponent;
  form: FormGroup;
  savedFormData: any;
  applicationId: string;
  busy: Subscription;
  busyPromise: Promise<any>;
  accountId: string;
  payMethod: string;
  validationMessages: any[];
  showValidationMessages: boolean;
  submittedApplications = 8;
  ServiceHours = ServiceHours;
  tiedHouseFormData: TiedHouseConnection;
  possibleProblematicNameWarning = false;
  htmlContent: ApplicationHTMLContent = <ApplicationHTMLContent>{};
  indigenousNations: { id: string, name: string }[] = [];
  readonly UPLOAD_FILES_MODE = UPLOAD_FILES_MODE;
  FormControlState = FormControlState;
  mode: string;
  account: Account;

  uploadedSupportingDocuments = 0;
  uploadedFinancialIntegrityDocuments: 0;
  uploadedAssociateDocuments: 0;
  uploadedSignageDocuments: 0;
  uploadedValidInterestDocuments: 0;
  uploadedSitePlanDocuments: 0;
  uploadedFloorPlanDocuments: 0;
  uploadedPhotosOrRenderingsDocuments: 0;
  uploadedZoningDocuments: 0;
  dynamicsForm: DynamicsForm;

  get isOpenedByLG(): boolean {
    let openedByLG = false;
    if(this.account && this.application && 
      this.account.localGovernmentId && this.application.indigenousNationId &&
      this.account.localGovernmentId === this.application.indigenousNationId){
      openedByLG = true;
    }
    return openedByLG;
  }

  constructor(private store: Store<AppState>,
    private paymentDataService: PaymentDataService,
    public snackBar: MatSnackBar,
    public router: Router,
    public applicationDataService: ApplicationDataService,
    private dynamicsDataService: DynamicsDataService,
    public featureFlagService: FeatureFlagService,
    private route: ActivatedRoute,
    private fb: FormBuilder,
    private tiedHouseService: TiedHouseConnectionsDataService,
    public dialog: MatDialog,
    public establishmentWatchWordsService: EstablishmentWatchWordsService,
    private accountDataService: AccountDataService,
    private dynamicsFormDataService: DynamicsFormDataService
  ) {
    super();
    this.route.paramMap.subscribe(pmap => this.applicationId = pmap.get('applicationId'));
    this.route.paramMap.subscribe(pmap => this.mode = pmap.get('mode'));
  }

  ngOnInit() {


    this.form = this.fb.group({
      id: [''],
      assignedLicence: this.fb.group({
        id: [''],
        establishmentAddressStreet: [''],
        establishmentAddressCity: [''],
        establishmentAddressPostalCode: [''],
        establishmentParcelId: ['']
      }),
      establishmentName: ['', [
        Validators.required,
        this.establishmentWatchWordsService.forbiddenNameValidator()
      ]],
      establishmentParcelId: ['', [Validators.required, Validators.maxLength(9), Validators.minLength(9)]],
      contactPersonFirstName: ['', Validators.required],
      contactPersonLastName: ['', Validators.required],
      contactPersonRole: [''],
      contactPersonEmail: ['', Validators.required],
      contactPersonPhone: ['', Validators.required],
      establishmentAddressStreet: ['', Validators.required],
      establishmentAddressCity: ['', Validators.required],
      establishmentAddressPostalCode: ['', [Validators.required, Validators.pattern(CanadaPostalRegex)]],
      establishmentEmail: ['', Validators.email],
      establishmentPhone: [''],
      serviceHoursSundayOpen: ['', Validators.required],
      serviceHoursMondayOpen: ['', Validators.required],
      serviceHoursTuesdayOpen: ['', Validators.required],
      serviceHoursWednesdayOpen: ['', Validators.required],
      serviceHoursThursdayOpen: ['', Validators.required],
      serviceHoursFridayOpen: ['', Validators.required],
      serviceHoursSaturdayOpen: ['', Validators.required],
      serviceHoursSundayClose: ['', Validators.required],
      serviceHoursMondayClose: ['', Validators.required],
      serviceHoursTuesdayClose: ['', Validators.required],
      serviceHoursWednesdayClose: ['', Validators.required],
      serviceHoursThursdayClose: ['', Validators.required],
      serviceHoursFridayClose: ['', Validators.required],
      serviceHoursSaturdayClose: ['', Validators.required],
      liquorDeclarationCheck: [''],
      applyAsIndigenousNation: [false],
      indigenousNationId: [{ value: null, disabled: true }, Validators.required],
      federalProducerNames: ['', Validators.required],
      applicantType: ['', Validators.required],
      description1: ['', [Validators.required]],
      proposedChange: ['', [Validators.required]],
      connectedGrocery: ['', []],
      authorizedToSubmit: [''],
      signatureAgreement: [''],
      mfgType: ['', []],
      brewPub: ['', []],
      pipedIn: ['', []],
      neutralGrain: ['', []],
      zoningPermitsMFG: ['', []],
      zoningPermitsRetailSales: ['', []],
      isALR: ['', []],
      meetsALRRequirements: ['', []],
    });

    this.form.get('applyAsIndigenousNation').valueChanges.subscribe((applyAsIN: boolean) => {
      if (applyAsIN && this.application.applicationType.name === this.ApplicationTypeNames.CannabisRetailStore) {
        this.form.get('applicantType').setValue('IndigenousNation');
        this.form.get('indigenousNationId').enable();
      } else {
        this.form.get('applicantType').setValue(this.account.businessType);
        this.form.get('indigenousNationId').disable();
      }
      this.addDynamicContent();
    });

    this.applicationDataService.getSubmittedApplicationCount()
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(value => this.submittedApplications = value);

    this.establishmentWatchWordsService.initialize();

    this.store.select(state => state.currentAccountState.currentAccount)
      .pipe(takeWhile(() => this.componentActive))
      .pipe(filter(account => !!account))
      .subscribe((account) => {
        this.account = account;
      });

    this.dynamicsDataService.getRecord('indigenousnations', '')
      .subscribe(data => this.indigenousNations = data);


    this.busy = this.applicationDataService.getApplicationById(this.applicationId)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: Application) => {
        if (data.establishmentParcelId) {
          data.establishmentParcelId = data.establishmentParcelId.replace(/-/g, '');
        }
        if (data.applicantType === 'IndigenousNation') {
          (<any>data).applyAsIndigenousNation = true;
        }

        this.application = data;

        this.hideFormControlByType();

        this.addDynamicContent();

        if (data.applicationType.formReference) {
          console.log("Getting form layout");
          // get the application form        
          this.dynamicsForm = data.applicationType.dynamicsForm;
          this.dynamicsForm.tabs.forEach(function (tab) {
            tab.sections.forEach(function (section) {
              if (section.fields) {
                section.fields.forEach(function (field) {
                  // add the field to the form.
                  if (field.required) {
                    this.form.addControl(field.datafieldname, new FormControl('', Validators.required));
                  }
                  else {
                    this.form.addControl(field.datafieldname, new FormControl(''));
                  }
                }, this);
              }

            }, this);
          }, this);
        }

        const noNulls = Object.keys(data)
          .filter(e => data[e] !== null)
          .reduce((o, e) => {
            o[e] = data[e];
            return o;
          }, {});

        this.form.patchValue(noNulls);

        if (data.isPaid) {
          this.form.disable();
        }
        this.savedFormData = this.form.value;


      },
        () => {
          console.log('Error occured');
        }
      );



  }

  private hideFormControlByType() {
    if (!this.application.applicationType.showPropertyDetails) {
      this.form.get('establishmentAddressStreet').disable();
      this.form.get('establishmentAddressCity').disable();
      this.form.get('establishmentAddressPostalCode').disable();
      this.form.get('establishmentName').disable();
      this.form.get('establishmentParcelId').disable();
    }

    if (this.application.applicationType.newEstablishmentAddress !== FormControlState.Show) {
      this.form.get('establishmentAddressStreet').disable();
      this.form.get('establishmentAddressCity').disable();
      this.form.get('establishmentAddressPostalCode').disable();
      this.form.get('establishmentParcelId').disable();
    }

    if (this.application.applicationType.establishmentName !== FormControlState.Show) {
      this.form.get('establishmentName').disable();
    }

    if (this.application.applicationType.storeContactInfo !== FormControlState.Show) {
      this.form.get('establishmentEmail').disable();
      this.form.get('establishmentPhone').disable();
    }

    if (!this.application.applicationType.showHoursOfSale) {
      // Opening hours
      this.form.get('serviceHoursSundayOpen').disable();
      this.form.get('serviceHoursMondayOpen').disable();
      this.form.get('serviceHoursTuesdayOpen').disable();
      this.form.get('serviceHoursWednesdayOpen').disable();
      this.form.get('serviceHoursThursdayOpen').disable();
      this.form.get('serviceHoursFridayOpen').disable();
      this.form.get('serviceHoursSaturdayOpen').disable();
      // Closing hours
      this.form.get('serviceHoursSundayClose').disable();
      this.form.get('serviceHoursMondayClose').disable();
      this.form.get('serviceHoursTuesdayClose').disable();
      this.form.get('serviceHoursWednesdayClose').disable();
      this.form.get('serviceHoursThursdayClose').disable();
      this.form.get('serviceHoursFridayClose').disable();
      this.form.get('serviceHoursSaturdayClose').disable();
    }

    if (this.application.applicationType.name !== ApplicationTypeNames.Marketer) {
      this.form.get('federalProducerNames').disable();
    }

    if (this.application.applicationType.name !== ApplicationTypeNames.CRSStructuralChange
      && this.application.applicationType.name !== ApplicationTypeNames.CRSEstablishmentNameChange) {
      this.form.get('proposedChange').disable();
    }

    if (!this.application.applicationType.showDescription1) {
      this.form.get('description1').disable();
    }

    if (this.application.applicationType.showLiquorDeclarations) {
      this.form.get('liquorDeclarationCheck').setValidators([this.customRequiredCheckboxValidator()]);
    }

    if (this.application.applicationType.showDeclarations) {
      this.form.get('authorizedToSubmit').setValidators([this.customRequiredCheckboxValidator()]);
      this.form.get('signatureAgreement').setValidators([this.customRequiredCheckboxValidator()]);
    }

    // 03/01/2020 - Disabled until connected grocery store feature is ready
    // if (this.application.applicationType.connectedGroceryStore !== FormControlState.Show) {
    //   this.form.get('connectedGrocery').clearValidators();
    // } else {
    //   this.form.get('connectedGrocery').setValidators([Validators.required]);
    // }


  }


  private isHoursOfSaleValid(): boolean {
    return !this.application.applicationType.showHoursOfSale ||
      (this.form.get('serviceHoursSundayOpen').valid
        && this.form.get('serviceHoursMondayOpen').valid
        && this.form.get('serviceHoursTuesdayOpen').valid
        && this.form.get('serviceHoursWednesdayOpen').valid
        && this.form.get('serviceHoursThursdayOpen').valid
        && this.form.get('serviceHoursFridayOpen').valid
        && this.form.get('serviceHoursSaturdayOpen').valid
        && this.form.get('serviceHoursSundayClose').valid
        && this.form.get('serviceHoursMondayClose').valid
        && this.form.get('serviceHoursTuesdayClose').valid
        && this.form.get('serviceHoursWednesdayClose').valid
        && this.form.get('serviceHoursThursdayClose').valid
        && this.form.get('serviceHoursFridayClose').valid
        && this.form.get('serviceHoursSaturdayClose').valid
      );
  }

  canDeactivate(): Observable<boolean> {
    const connectionsDidntChang = !(this.connectionsToProducers && this.connectionsToProducers.formHasChanged());
    const formDidntChange = JSON.stringify(this.savedFormData) === JSON.stringify(this.form.value);
    if (connectionsDidntChang && formDidntChange) {
      return of(true);
    } else {
      const subj = new Subject<boolean>();
      this.busy = this.save(true).subscribe(res => {
        subj.next(res);
      });
      return subj;
    }
  }

  checkPossibleProblematicWords() {
    console.log(this.form.get('establishmentName').errors);
    this.possibleProblematicNameWarning =
      this.establishmentWatchWordsService.potentiallyProblematicValidator(this.form.get('establishmentName').value);
  }

  showSitePlan(): boolean {
    let show = this.application
      && this.application.applicationType
      && (this.showFormControl(this.application.applicationType.sitePlan) 
        || this.showFormControl(this.application.applicationType.showLiquorSitePlan));

    if (this.application && this.application.applicationType.name === ApplicationTypeNames.CRSStructuralChange) {
      show = this.showFormControl(this.application.applicationType.sitePlan)
        && this.form.get('proposedChange').value === 'Yes';
    }

    return show;
  }


  showZoning(): boolean {
    let show = this.application
      && this.application.applicationType
      && this.showFormControl(this.application.applicationType.proofofZoning);
    return show;

  }

  showExteriorChangeQuestion():boolean {
    let show = this.application &&
                (this.application.applicationType.name === ApplicationTypeNames.CRSEstablishmentNameChange 
                && this.application.licenseType === 'Cannabis Retail Store');

    if(show){
      this.form.get('proposedChange').setValidators([Validators.required]);
      this.form.updateValueAndValidity();
    } else {
      this.form.get('proposedChange').setValidators([]);
      this.form.updateValueAndValidity();
    }
    return show;
  }

  showExteriorRenderings() {
    let show = this.application &&
      (this.application.applicationType.name === ApplicationTypeNames.CRSEstablishmentNameChange
        || this.application.applicationType.name === ApplicationTypeNames.CRSStructuralChange);
    show = show && this.form.get('proposedChange').value === 'Yes';
    return show;
  }

  showGroceryQuestion() {
    let show = this.application
      && this.application.applicationType
      && this.showFormControl(this.application.applicationType.connectedGroceryStore);
    return show;
  }

  showGroceryStore() {
    let show = (this.application && this.showFormControl(this.application.applicationType.connectedGroceryStore));
    show = show && this.form.get('connectedGrocery').value === 'Yes';
    return show;
  }

  onAccountSelect(proposedAccount: TransferAccount) {
    this.form.get('proposedTPO').patchValue(proposedAccount);
  }


  /* Helper functions for the Manufactuer Licence Business Plan
    There are a lot of conditional requirements depending on what is selected.
    Most are self explanatory
  */

  hasType(): boolean {
    // to do, set validation requirements
  return this.form.get('mfgType').value
  }

  isBrewery(): boolean {
    // to do, set validation requirements
    return this.form.get('mfgType').value == "Brewery"
  }
  isWinery(): boolean {
    // to do, set validation requirements
    return this.form.get('mfgType').value == "Winery"
  }
  isDistillery(): boolean {
    return this.form.get('mfgType').value == "Distillery"
  }
  
  isBrewPub(): boolean {
    // to do, set validation requirements
    return this.form.get('mfgType').value == "Brewery" && this.form.get('brewPub').value == "Yes"
  }



  /**
   * Save form data
   * @param showProgress
   */
  save(showProgress: boolean = false): Observable<boolean> {
    const saveData = this.form.value;

    // do not save if the form is in file upload mode
    if (this.mode === UPLOAD_FILES_MODE) {
      // a delay is need by the deactivate guard
      return of(true).pipe(delay(10));
    }
    return forkJoin(
      this.applicationDataService.updateApplication({ ...this.application, ...this.form.value }),
      this.prepareTiedHouseSaveRequest(this.tiedHouseFormData)
    ).pipe(takeWhile(() => this.componentActive))
      .pipe(catchError(() => {
        this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        return of(false);
      }))
      .pipe(mergeMap(() => {
        this.savedFormData = saveData;
        this.updateApplicationInStore();
        if (showProgress === true) {
          this.snackBar.open('Application has been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
        }
        return of(true);
      }));
  }


  saveForLater() {
    this.busyPromise = this.save(true)
      .toPromise()
      .then(() => {
        this.router.navigateByUrl('/dashboard');
      });
  }

  prepareTiedHouseSaveRequest(_tiedHouseData) {
    if (!this.application.tiedHouse) {
      return of(null);
    }
    let data = (<any>Object).assign(this.application.tiedHouse, _tiedHouseData);
    data = { ...data };
    return this.tiedHouseService.updateTiedHouse(data, data.id);
  }

  updateApplicationInStore() {
    this.applicationDataService.getApplicationById(this.applicationId)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: Application) => {
        this.store.dispatch(new currentApplicationActions.SetCurrentApplicationAction(data));
      }
      );
  }

  /**
   * Submit the application for payment
   * */
  submit_application() {
    const formChanged: boolean = (JSON.stringify(this.savedFormData) !== JSON.stringify(this.form.value)); // has the data been updated?
      const save: Observable<boolean> = formChanged ? this.save(!this.application.applicationType.isFree) : of(true); // bypass save if form value not updated

    // Only save if the data is valid
    if (this.isValid()) {
      this.busy = save
        .pipe(takeWhile(() => this.componentActive))
        .subscribe((result: boolean) => {
          if (result) {
            this.saveComplete.emit(true);
            // redirect to dashboard if the applicationType is FREE
            if (this.application.applicationType.isFree) {
              this.snackBar.open('Application submitted', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
              this.router.navigateByUrl('/dashboard');
            } else {
              this.submitPayment();
            }
          } else if (this.application.applicationType.isFree) { // show error message the save failed and the application is free
            this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          }
        });
    } else {
      this.showValidationMessages = true;
    }
  }

  /**
   * Redirect to payment processing page (Express Pay / Bambora service)
   * */
  private submitPayment() {
    if (this.skipPayment) {
      return;
    }

    this.busy = this.paymentDataService.getPaymentSubmissionUrl(this.applicationId)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(jsonUrl => {
        window.location.href = jsonUrl['url'];
        return jsonUrl['url'];
      }, err => {
        if (err._body === 'Payment already made') {
          this.snackBar.open('Application payment has already been made.', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        }
      });
  }

  isValid(): boolean {
    this.markConstrolsAsTouched(this.form);

    this.showValidationMessages = false;
    let valid = true;
    this.validationMessages = this.listControlsWithErrors(this.form, this.getValidationErrorMap());

    // handle supporting documents for sole proprietor who submit marketing applications 
    let marketing_soleprop = this.application.applicationType.name === ApplicationTypeNames.Marketer && this.account.businessType === "SoleProprietor";


    if (this.application.applicationType.showAssociatesFormUpload &&
      ((this.uploadedAssociateDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('Associate form is required.');
    }

    if (this.application.applicationType.showFinancialIntegrityFormUpload &&
      ((this.uploadedFinancialIntegrityDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('Financial Integrity form is required.');
    }

    // if we're showing supporting documents and it's not a marketing soleprop application add validation
    if (this.application.applicationType.showSupportingDocuments && !marketing_soleprop &&
      ((this.uploadedSupportingDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one supporting document is required.');
    }

    if (this.application.applicationType.signage === FormControlState.Show &&
      ((this.uploadedSignageDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one signage document is required.');
    }

    if (this.application.applicationType.validInterest === FormControlState.Show &&
      ((this.uploadedValidInterestDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one supporting document is required.');
    }

    if (this.showSitePlan() &&
      ((this.uploadedSitePlanDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one site plan document is required.');
    }

    if (this.showExteriorRenderings() &&
      ((this.uploadedPhotosOrRenderingsDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one store exterior rendering or photo is required.');
    }

    if (this.application.applicationType.floorPlan === FormControlState.Show &&
      ((this.uploadedFloorPlanDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one floor plan document is required.');
    }

    if (this.application.applicationType.proofofZoning === FormControlState.Show &&
      ((this.uploadedZoningDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one zoning document is required.');
    }



    if (this.application.applicationType.showPropertyDetails && !this.form.get('establishmentName').value) {
      valid = false;
      this.validationMessages.push('Establishment name is required.');
    }
    if (this.application.applicationType.name === ApplicationTypeNames.CannabisRetailStore && this.submittedApplications >= 8) {
      valid = false;
      this.validationMessages.push('Only 8 applications can be submitted');
    }
    if (!this.isHoursOfSaleValid()) {
      this.validationMessages.push('Hours of sale are required');
    }

    return valid && this.form.valid;
  }

  getValidationErrorMap() {
    let errorMap = {
      establishmentName: (_ => {
        let control = this.getEstablishmentLabel(<ApplicationTypeNames>(this.application.applicationType.name))
        let message = '';
        if (this.form && this.form.get('establishmentName')) {
          let errors = this.form.get('establishmentName').errors;
          if (errors && errors.required) {
            message += `${control} is required`;
          } else if (errors && errors.forbiddenName) {
            message += `The store name contains at least one word that doesn’t comply with naming requirements.`;
          }
        }
        return message;
      })(),
      establishmentParcelId: 'Please enter the Parcel Identifier (format: 9 digits)',
      contactPersonFirstName: 'Please enter the business contact\'s first name',
      contactPersonLastName: 'Please enter the business contact\'s last name',
      contactPersonEmail: 'Please enter the business contact\'s email address',
      contactPersonPhone: 'Please enter the business contact\'s 10-digit phone number',
      establishmentAddressStreet: 'Please enter the street address',
      establishmentAddressCity: 'Please enter the city',
      establishmentAddressPostalCode: 'Please enter the postal code',
      establishmentEmail: 'Please enter the email address for the store',
      establishmentPhone: 'Please enter the store phone number',
      authorizedToSubmit: 'Please affirm that you are authorized to submit the application.',
      signatureAgreement: 'Please affirm that all of the information provided for this application is true and complete',
      indigenousNationId: 'Please select the Indigenous nation',
      federalProducerNames: 'Please enter the name of federal producer',
      description1: 'Please enter a description',
    };

    return errorMap;
  }


  /**
   * Dialog to confirm the application cancellation (status changed to "Termindated")
   */
  cancelApplication() {

    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      width: '400px',
      height: '200px',
      data: {
        establishmentName: this.application.establishmentName,
        applicationName: this.application.name
      }
    };

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(ApplicationCancellationDialogComponent, dialogConfig);
    dialogRef.afterClosed()
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(cancelApplication => {
        if (cancelApplication) {
          // delete the application.
          this.busy = this.applicationDataService.cancelApplication(this.applicationId)
            .pipe(takeWhile(() => this.componentActive))
            .subscribe(() => {
              this.savedFormData = this.form.value;
              this.router.navigate(['/dashboard']);
            },
              () => {
                this.snackBar.open('Error cancelling the application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
                console.error('Error cancelling the application');
              });
        }
      });
  }

  businessTypeIsPartnership(): boolean {
    return this.account &&
      ['GeneralPartnership',
        'LimitedPartnership',
        'LimitedLiabilityPartnership',
        'Partnership'].indexOf(this.account.businessType) !== -1;
  }

  businessTypeIsPrivateCorporation(): boolean {
    return this.account &&
      ['PrivateCorporation',
        'UnlimitedLiabilityCorporation',
        'LimitedLiabilityCorporation'].indexOf(this.account.businessType) !== -1;
  }

  isCRSRenewalApplication(): boolean {
    return this.application
      && this.application.applicationType
      && [
        ApplicationTypeNames.CRSRenewal.toString(),
        ApplicationTypeNames.CRSRenewalLate30.toString(),
        ApplicationTypeNames.CRSRenewalLate6Months.toString(),
      ].indexOf(this.application.applicationType.name) !== -1;
  }

  showFormControl(state: string): boolean {
    return [FormControlState.Show.toString(), FormControlState.Reaonly.toString()]
      .indexOf(state) !== -1;
  }

  getEstablishmentLabel(applicationTypeName: ApplicationTypeNames): string {
    let label = 'Establishment Name';
    if ([ApplicationTypeNames.CRSTransferofOwnership, ApplicationTypeNames.CRSLocationChange].indexOf(applicationTypeName) !== -1) {
      label = 'Name of the Proposed Establishment';
    } else if (applicationTypeName === ApplicationTypeNames.CRSEstablishmentNameChange) {
      label = 'Proposed New Name';
    }
    return label;
  }
}
