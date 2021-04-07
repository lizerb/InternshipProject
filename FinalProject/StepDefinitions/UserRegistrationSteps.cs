using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Hooks;
using FinalProject.PageObjects;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps
    {
        private readonly Context _context;
        private static IWebDriver _driver;

        public UserRegistrationSteps(Context context)
        {
            _context = context;
            _driver = context.Driver;
        }

        private readonly HomePO homePO = new HomePO(_driver);
        private readonly LoginPO loginPO = new LoginPO(_driver);
        private readonly CreateAccountPO createAccountPO = new CreateAccountPO(_driver);

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
            loginPO.InsertEmail("lize@hotmail.com");
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
            //createAccountPO.InsertFirstNameAddress("");
            //createAccountPO.InsertLastNameAddress("");
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
            StringAssert.Contains(_driver.Url, "account-creation");
            StringAssert.Contains(_driver.PageSource, "Create an account");
        }
        
        [Then(@"I should be able to finish my registration in the online store")]
        public void ThenIShouldBeAbleToFinishMyRegistrationInTheOnlineStore()
        {
           // Welcome to your account. Here you can manage all of your personal information and orders.
        }
        
        [Then(@"a message must be shown saying that all the mandatory fields must be informed")]
        public void ThenAMessageMustBeShownSayingThatAllTheMandatoryFieldsMustBeInformed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
