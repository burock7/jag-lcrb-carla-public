// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_endorsement
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioEndorsement
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsement class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEndorsement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEndorsement class.
        /// </summary>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="statecode">Status of the Endorsement</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="statuscode">Reason for the status of the
        /// Endorsement</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="adoxioEndorsementid">Unique identifier for entity
        /// instances</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="versionnumber">Version Number</param>
        public MicrosoftDynamicsCRMadoxioEndorsement(string _owninguserValue = default(string), int? importsequencenumber = default(int?), string adoxioName = default(string), string _createdbyValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), int? statecode = default(int?), string _owningteamValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _adoxioEndorsementtypeValue = default(string), string _modifiedbyValue = default(string), string adoxioEndorsementid = default(string), int? timezoneruleversionnumber = default(int?), string _adoxioLicenceValue = default(string), string _createdonbehalfbyValue = default(string), string _owneridValue = default(string), string versionnumber = default(string), string _adoxioApplicationValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioEndorsementSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEndorsementDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEndorsementDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioEndorsementSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioEndorsementAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioEndorsementBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioEndorsementtype adoxioEndorsementType = default(MicrosoftDynamicsCRMadoxioEndorsementtype), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences))
        {
            this._owninguserValue = _owninguserValue;
            Importsequencenumber = importsequencenumber;
            AdoxioName = adoxioName;
            this._createdbyValue = _createdbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Createdon = createdon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            this._adoxioEndorsementtypeValue = _adoxioEndorsementtypeValue;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioEndorsementid = adoxioEndorsementid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owneridValue = _owneridValue;
            Versionnumber = versionnumber;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioEndorsementSyncErrors = adoxioEndorsementSyncErrors;
            AdoxioEndorsementDuplicateMatchingRecord = adoxioEndorsementDuplicateMatchingRecord;
            AdoxioEndorsementDuplicateBaseRecord = adoxioEndorsementDuplicateBaseRecord;
            AdoxioEndorsementSharePointDocumentLocations = adoxioEndorsementSharePointDocumentLocations;
            AdoxioEndorsementAsyncOperations = adoxioEndorsementAsyncOperations;
            AdoxioEndorsementBulkDeleteFailures = adoxioEndorsementBulkDeleteFailures;
            AdoxioEndorsementType = adoxioEndorsementType;
            AdoxioApplication = adoxioApplication;
            AdoxioLicence = adoxioLicence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets status of the Endorsement
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Endorsement
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_endorsementtype_value")]
        public string _adoxioEndorsementtypeValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsementid")]
        public string AdoxioEndorsementid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioEndorsementSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEndorsementDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEndorsementDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioEndorsementSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioEndorsementAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_endorsement_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioEndorsementBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EndorsementType")]
        public MicrosoftDynamicsCRMadoxioEndorsementtype AdoxioEndorsementType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

    }
}