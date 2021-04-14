using FinalProject.Hooks;
using FinalProject.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class UserLoginSteps
    {
        private readonly IWebDriver _driver;

        private readonly HomePO homePO;
        private readonly LoginPO loginPO;

        public UserLoginSteps(Context context)
        {
            _driver = context.Driver;
            homePO = new HomePO(_driver);
            loginPO = new LoginPO(_driver);
        }

        [Given(@"that I am a customer who already has an account")]
        public void GivenThatIAmACustomerWhoAlreadyHasAnAccount()
        {
            homePO.Visit();
        }

        [When(@"I access the Sign In page")]
        public void WhenIAccessTheSignInPage()
        {
            homePO.ClickSignInButton();
        }

        [When(@"I inform the email ""(.*)"" and the password ""(.*)""")]
        public void WhenIInformTheEmailAndThePassword(string email, string password)
        {
            loginPO.InsertEmail(email);
            loginPO.InsertPassword(password);
            loginPO.ClickSignInButton();
        }
        
        [When(@"I try to log in without register information")]
        public void WhenITryToLogInWithoutRegisterInformation()
        {
            loginPO.ClickSignInButton();
        }
        
        [Then(@"I will be redirected to the My Account page")]
        public void ThenIWillBeRedirectedToTheMyAccountPage()
        {
            _driver.Url.Should().Contain("controller=my-account");
            _driver.PageSource.Should().Contain(
                "Welcome to your account. Here you can manage all of your personal information and orders");            
        }
    }
}
