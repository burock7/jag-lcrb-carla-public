﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: UBrewUVinLicenceNameChange
    As a logged in business user
    I want to submit a UBrew / UVin Licence name change application for different business types

@ubrewuvinnamechange @partnership 
Scenario: DEV UBrew / UVin Application Establishment Name Change (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a partnership
    And I complete the UBrew / UVin application for a partnership
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I click on the Licences tab
    And I request a valid store name or branding change for UBrew
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinnamechange @privatecorporation 
Scenario: DEV UBrew / UVin Application Establishment Name Change (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a private corporation
    And I complete the UBrew / UVin application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I click on the Licences tab
    And I request a valid store name or branding change for UBrew
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinnamechange @publiccorporation 
Scenario: DEV UBrew / UVin Application Establishment Name Change (Public Corporation)
    Given I am logged in to the dashboard as a public corporation
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a public corporation
    And I complete the UBrew / UVin application for a public corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I click on the Licences tab
    And I request a valid store name or branding change for UBrew
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@ubrewuvinnamechange @soleproprietorship 
Scenario: DEV UBrew / UVin Application Establishment Name Change (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a sole proprietorship
    And I complete the UBrew / UVin application for a sole proprietorship
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I click on the Licences tab
    And I request a valid store name or branding change for UBrew
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

#@ubrewuvinnamechange @partnership 
#Scenario: UAT UBrew / UVin Application Establishment Name Change (Partnership)
#    Given I am logged in to the dashboard as a partnership
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a partnership
#    And I review the organization structure for a partnership
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a partnership
#    And I click on the Submit button
#    And I review the security screening requirements for a partnership
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the application is approved
#    And I click on the Licences tab
#    And I pay the licensing fee 
#    And I click on the Licences tab
#    And I request a valid store name or branding change for UBrew
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
#
#@ubrewuvinnamechange @privatecorporation 
#Scenario: UAT UBrew / UVin Application Establishment Name Change (Private Corporation)
#    Given I am logged in to the dashboard as a private corporation
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a private corporation
#    And I review the organization structure for a private corporation
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a private corporation
#    And I click on the Submit button
#    And I review the security screening requirements for a private corporation
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the application is approved
#    And I click on the Licences tab
#    And I pay the licensing fee 
#    And I click on the Licences tab
#    And I request a valid store name or branding change for UBrew
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
#
#@ubrewuvinnamechange @publiccorporation 
#Scenario: UAT UBrew / UVin Application Establishment Name Change (Public Corporation)
#    Given I am logged in to the dashboard as a public corporation
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a public corporation
#    And I review the organization structure for a public corporation
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a public corporation
#    And I click on the Submit button
#    And I review the security screening requirements for a public corporation
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the application is approved
#    And I click on the Licences tab
#    And I pay the licensing fee 
#    And I click on the Licences tab
#    And I request a valid store name or branding change for UBrew
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
#
#@ubrewuvinnamechange @soleproprietorship 
#Scenario: UAT UBrew / UVin Application Establishment Name Change (Sole Proprietorship)
#    Given I am logged in to the dashboard as a sole proprietorship
#    And I click on the Start Application button for a UBrew UVin application
#    And I review the account profile for a sole proprietorship
#    And I review the organization structure for a sole proprietorship
#    And I click on the button for Submit Organization Information
#    And I complete the UBrew / UVin application for a sole proprietorship
#    And I click on the Submit button
#    And I review the security screening requirements for a sole proprietorship
#    And I click on the button for Pay for Application
#    And I enter the payment information
#    And I confirm the payment receipt for a UBrew / UVin application
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the application is approved
#    And I click on the Licences tab
#    And I pay the licensing fee 
#    And I click on the Licences tab
#    And I request a valid store name or branding change for UBrew
#    And I click on the Dashboard tab
#    And the dashboard status is updated as Application Under Review
#    And the account is deleted
#    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./UBrewUVinLicenceNameChange.feature")]
    [Collection("Liquor")]
    public sealed class UBrewUVinLicenceNameChange : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorOne();

            CheckFeatureFlagsLGIN();

            CheckFeatureFlagsIN();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}