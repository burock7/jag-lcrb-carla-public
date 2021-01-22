﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [Given(@"I am not logged in to the Liquor and Cannabis Portal")]
        public void NotLoggedInCOVID()
        {
            NavigateToFeatures();

            CheckFeatureFlagsCOVIDTempExtension();

            IgnoreSynchronizationFalse();
        }


        [And(@"I click on the COVID Temporary Extension link")]
        public void ClickOnCovidTemp()
        {
            ngDriver.Navigate().GoToUrl($"{baseUri}covid-temporary-extension");
        }


        [And(@"I complete the temporary extension application for a (.*)")]
        public void CompleteApplication(string licenceType)
        {
            /* 
            Page Title: Covid Temporary Extension Application
            */

            // create test data
            string licencenumber = "123456";
            string licenceename = "Point Ellis Operations";
            string estname = "Point Ellis Greenhouse";
            string eststreet = "645 Tyee Road";
            string estcity = "Victoria";
            string estpostal = "V8V4Y3";
            string contactfirst = "ContactFirst";
            string contactlast = "ContactLast";
            string contacttitle = "Director";
            string contacttel = "2501811181";
            string contactemail = "contact@email.com";
            string mailingstreet = "MailingStreet";
            string mailingcity = "MailingCity";
            string mailingpostal = "V8V4Y3";

            // enter the licence number
            NgWebElement uiLicenceNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'description1']"));
            uiLicenceNumber.SendKeys(licencenumber);

            if (licenceType == "Food Primary licence")
            {
                // select the food primary licence type
                NgWebElement uiLicenceType = ngDriver.FindElement(By.CssSelector("[formcontrolname='licenceType'] .mat-radio-button[value='Food Primary']"));
                uiLicenceType.Click();
            }

            if (licenceType == "Liquor Primary licence")
            {
                // select the licence type for Liquor Primary
                NgWebElement uiLicenceType1 = ngDriver.FindElement(By.CssSelector("[formcontrolname='licenceType'] .mat-radio-button[value='Liquor Primary']"));
                uiLicenceType1.Click();
            }

            if (licenceType == "Liquor Primary Club licence")
            {
                // select the licence type for Liquor Primary Club
                NgWebElement uiLicenceType2 = ngDriver.FindElement(By.CssSelector("[formcontrolname='licenceType'] .mat-radio-button[value='Liquor Primary Club']"));
                uiLicenceType2.Click();
            }

            if (licenceType == "Manufacturer licence")
            {
                // select the licence type for Winery
                NgWebElement uiLicenceType3 = ngDriver.FindElement(By.CssSelector("[formcontrolname='licenceType'] .mat-radio-button[value='Manufacturer']"));
                uiLicenceType3.Click();
            }

            // enter the establishment name
            NgWebElement uiEstName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='establishmentName']"));
            uiEstName.SendKeys(estname);

            // enter the establishment street
            NgWebElement uiEstStreet = ngDriver.FindElement(By.CssSelector("input[formcontrolname='establishmentAddressStreet']"));
            uiEstStreet.SendKeys(eststreet);

            // enter the establishment city
            NgWebElement uiEstCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname='establishmentAddressCity']"));
            uiEstCity.SendKeys(estcity);

            // enter the establishment postal code
            NgWebElement uiEstPostal = ngDriver.FindElement(By.CssSelector("input[formcontrolname='establishmentAddressPostalCode']"));
            uiEstPostal.SendKeys(estpostal);

            // select 'No' for ALR location
            NgWebElement uiIsALRFalse = ngDriver.FindElement(By.CssSelector("[formcontrolname='proposedEstablishmentIsAlr'] mat-radio-button[value='false']"));
            uiIsALRFalse.Click();

            // select 'Yes' for ALR location
            NgWebElement uiIsALRTrue = ngDriver.FindElement(By.CssSelector("[formcontrolname='proposedEstablishmentIsAlr'] mat-radio-button[value='true']"));
            uiIsALRTrue.Click();

            // enter the licencee name
            NgWebElement uiLicenceeName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='nameOfApplicant']"));
            uiLicenceeName.SendKeys(licenceename);

            // enter the contact first name
            NgWebElement uiContactFirst = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonFirstName']"));
            uiContactFirst.SendKeys(contactfirst);

            // enter the contact last name
            NgWebElement uiContactLast = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonLastName']"));
            uiContactLast.SendKeys(contactlast);

            // enter the contact title
            NgWebElement uiContactTitle = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonRole']"));
            uiContactTitle.SendKeys(contacttitle);

            // enter the contact phone number
            NgWebElement uiContactTel = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonPhone']"));
            uiContactTel.SendKeys(contacttel);

            // enter the contact email
            NgWebElement uiContactEmail = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonEmail']"));
            uiContactEmail.SendKeys(contactemail);

            // enter the mailing street
            NgWebElement uiMailingStreet = ngDriver.FindElement(By.CssSelector("input[formcontrolname='addressStreet']"));
            uiMailingStreet.Clear();
            uiMailingStreet.SendKeys(mailingstreet);

            // enter the mailing city
            NgWebElement uiMailingCity = ngDriver.FindElement(By.CssSelector("input[formcontrolname='addressCity']"));
            uiMailingCity.Clear();
            uiMailingCity.SendKeys(mailingcity);

            // enter the mailing postal code
            NgWebElement uiMailingPostal = ngDriver.FindElement(By.CssSelector("input[formcontrolname='addressPostalCode']"));
            uiMailingPostal.Clear();
            uiMailingPostal.SendKeys(mailingpostal);

            // select the bounded status checkbox
            NgWebElement boundedStatus = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='boundedStatus']"));
            boundedStatus.Click();

            // upload a floor plan document
            FileUpload("floor_plan.pdf", "(//input[@type='file'])[2]");

            if (licenceType != "Food Primary licence")
            {
                // select LG/IN wishes to review radio button
                NgWebElement LGINReview = ngDriver.FindElement(By.CssSelector("[formcontrolname='lgStatus'] mat-radio-button[value='option2']"));
                LGINReview.Click();

                // upload LG/IN approval document
                FileUpload("LG_IN_approval.pdf","(//input[@type='file'])[8]");
            }

            // upload a representative notification form 
            FileUpload("licensee_rep_notification.pdf", "(//input[@type='file'])[5]");

            // click on the signature agreement checkbox
            NgWebElement uiSignatureAgreement = ngDriver.FindElement(By.CssSelector("mat-checkbox[formcontrolname='signatureAgreement']"));
            uiSignatureAgreement.Click();
        }


        [Then(@"the application is submitted")]
        public void ApplicationSubmitted()
        {
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Thank you for your submission.')]")).Displayed);
        }


        [And(@"I do not complete the temporary extension application")]
        public void DoNotCompleteApplication()
        {
            /* 
            Page Title: Covid Temporary Extension Application
            */

            // create unacceptable entry to generate error messages
            string licencenumber = " ";

            // enter the licence number and then clear it
            NgWebElement uiLicenceNumber = ngDriver.FindElement(By.CssSelector("input[formcontrolname='description1']"));
            uiLicenceNumber.SendKeys(licencenumber);

            // click on another field to generate error
            NgWebElement uiBody = ngDriver.FindElement(By.CssSelector("input[formcontrolname='establishmentName']"));
            uiBody.Click();

            // confirm that error message is displayed
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licence Number is a required field')]")).Displayed);
        }


        [Then(@"the COVID validation messages are displayed")]
        public void COVIDValidationMessagesDisplayed()
        {
            // confirm that error messages are displayed
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licence Number is a required field and must contain 6 digits')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licence Type is a required field')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Establishment Name is a required field')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Please confirm that the attached floor plan shows how the expanded area will be bounded')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Please identify your Local Goverment status')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Please affirm that all of the information provided for this application is true and complete.')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'The following fields are not valid:')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licence Number')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licence Type')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Licensee name')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Establishment name')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Establishmen Address Street')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Establishment Address City')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Business Telephone')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Business Email')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Contact First Name')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Contact Last Name')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Contact Title/Position')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Mailing Address Street')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Mailing Address City')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Mailing Address Postal Code')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Selection of the LG Option')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Confirmation of perimeter bounding')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Declaration checkbox')]")).Displayed);
            Assert.True(ngDriver.FindElement(By.XPath("//body[contains(.,'Missing Floor Plan Documents')]")).Displayed);
        }
    }
}
