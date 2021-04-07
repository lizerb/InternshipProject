using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Hooks;
using FinalProject.PageObjects;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps
    {        
        private static IWebDriver _driver;
        private readonly HomePO homePO;
        private readonly LoginPO loginPO;
        private readonly CreateAccountPO createAccountPO;

        public UserRegistrationSteps(Context context)
        {            
            _driver = context.Driver;
            homePO = new HomePO(_driver);
            loginPO = new LoginPO(_driver);
            createAccountPO = new CreateAccountPO(_driver);
        }               

        [Given(@"that I am a customer without registration")]
        public void GivenThatIAmACustomerWithoutRegistration()
        {
            homePO.Visit();            
        }
        
        [When(@"I click Sign in button")]
        public void WhenIClickSignInButton()
        {
            homePO.ClickSignInButton();
        }
        
        [When(@"I fill the e-mail text box")]
        public void WhenIFillTheE_MailTextBox()
        {
            loginPO.InsertEmail("janedoe@hotmail.com");
        }
        
        [When(@"I click the Create an Account button")]
        public void WhenIClickTheCreateAnAccountButton()
        {
            loginPO.ClickCreateAccountButton();
        }
        
        [When(@"I insert all the mandatory data")]
        public void WhenIInsertAllTheMandatoryData()
        {
            createAccountPO.InsertFirstName("Jane");
            createAccountPO.InsertLastName("Doe");
            createAccountPO.InsertPassword("12345");            
            createAccountPO.InsertAddress("Columbus street");
            createAccountPO.InsertCity("Montgomery");
            createAccountPO.InsertState("Alabama");
            createAccountPO.InsertPostalCode("90540");
            createAccountPO.InsertCountry("United States");
            createAccountPO.InsertMobilePhone("98765432");
        }

        [When(@"I click Register button")]
        public void WhenIClickRegisterButton()
        {
            createAccountPO.ClickRegisterButton();
        }

        [When(@"I access the Sign in page")]
        public void WhenIAccessTheSignInPage()
        {
            homePO.ClickSignInButton();
        }
        
        [When(@"I don't fill at least one of the mandatory fields of the registration form")]
        public void WhenIDonTFillAtLeastOneOfTheMandatoryFieldsOfTheRegistrationForm()
        {
            createAccountPO.InsertFirstName("Jane");
            createAccountPO.InsertLastName("Doe");
            createAccountPO.InsertPassword("12345");            
            createAccountPO.InsertAddress("Columbus street");
            createAccountPO.InsertCity("Montgomery");
            createAccountPO.InsertState("Alabama");
            createAccountPO.InsertPostalCode("90540");
            createAccountPO.InsertCountry("United States");
            // didn't insert mobile phone field
        }
        
        [Then(@"I will be redirected to the login page")]
        public void ThenIWillBeRedirectedToTheLoginPage()
        {
            StringAssert.Contains(_driver.Url, "my-account");
            StringAssert.Contains(_driver.PageSource, "Authentication");
        }
        
        [Then(@"I will be redirected to the registration page")]
        public void ThenIWillBeRedirectedToTheRegistrationPage()
        {            
            StringAssert.Contains(_driver.PageSource.ToLower(), "create an account".ToLower());
        }
        
        [Then(@"I should be able to finish my registration in the online store")]
        public void ThenIShouldBeAbleToFinishMyRegistrationInTheOnlineStore()
        {
            StringAssert.Contains(_driver.Url, "controller=my-account");
            StringAssert.Contains(_driver.PageSource, 
                "Welcome to your account. Here you can manage all of your personal information and orders.");            
        }
        
        [Then(@"a message must be shown saying that all the mandatory fields must be informed")]
        public void ThenAMessageMustBeShownSayingThatAllTheMandatoryFieldsMustBeInformed()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var displayed = wait.Until(drv => drv.FindElement(By.ClassName("alert alert-danger")));
            StringAssert.Contains(_driver.PageSource, "There is 1 error");            
        }
    }
}
