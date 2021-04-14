using FinalProject.Hooks;
using FinalProject.PageObjects;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps
    {        
        private readonly IWebDriver _driver;

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

        [When(@"I try to create a new account")]
        public void WhenITryToCreateANewAccount()
        {
            homePO.ClickSignInButton();
            loginPO.InsertEmailCreate($"{Guid.NewGuid()}@hotmail.com");
            loginPO.ClickCreateAccountButton();
        }

        [When(@"I fill all the registration form")]
        public void WhenIFillAllTheRegistrationForm()
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

            createAccountPO.ClickRegisterButton();
        }

        [When(@"I do not fill all the registration form")]
        public void WhenIDoNotFillAllTheRegistrationForm()
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

            createAccountPO.ClickRegisterButton();
        }                  
        
    }
}
