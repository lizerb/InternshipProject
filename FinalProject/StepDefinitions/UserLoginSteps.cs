using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Hooks;
using FinalProject.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

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
        
        [When(@"I click in the Sign in button at Home page")]
        public void WhenIClickInTheSignInButtonAtHomePage()
        {
            homePO.ClickSignInButton();
        }
        
        [When(@"I fill in the e-mail field with a registered e-mail")]
        public void WhenIFillInTheE_MailFieldWithARegisteredE_Mail()
        {
            loginPO.InsertEmail("janedoe@hotmail.com");
        }
        
        [When(@"I fill in the password field with the correct password")]
        public void WhenIFillInThePasswordFieldWithTheCorrectPassword()
        {
            loginPO.InsertPassword("12345");
        }
        
        [When(@"I click in the Sign in button at Login page")]
        public void WhenIClickInTheSignInButtonAtLoginPage()
        {
            loginPO.ClickSignInButton();
        }
        
        [When(@"I fill in the password field with an incorrect password")]
        public void WhenIFillInThePasswordFieldWithAnIncorrectPassword()
        {
            loginPO.InsertPassword("12346");
        }
        
        [When(@"I fill in the e-mail field with an unregistered e-mail")]
        public void WhenIFillInTheE_MailFieldWithAnUnregisteredE_Mail()
        {
            loginPO.InsertEmail("unregistered@hotmail.com");
        }
        
        [Then(@"I will be redirected to the My Account page")]
        public void ThenIWillBeRedirectedToTheMyAccountPage()
        {
            StringAssert.Contains(_driver.Url, "controller=my-account");
            StringAssert.Contains(_driver.PageSource,
                "Welcome to your account. Here you can manage all of your personal information and orders.");
        }

        [Then(@"an error message must be shown informing that the authentication failed")]
        public void ThenAnErrorMessageMustBeShownInformingThatTheAuthenticationFailed()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var displayed = wait.Until(drv => drv.FindElement(By.CssSelector("div.alert-danger")));
            StringAssert.Contains(_driver.PageSource.ToLower(), "Authentication failed.".ToLower());
        }

        [Then(@"an error message must be shown informing that an email is required")]
        public void ThenAnErrorMessageMustBeShownInformingThatAnEmailIsRequired()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var displayed = wait.Until(drv => drv.FindElement(By.CssSelector("div.alert-danger")));
            StringAssert.Contains(_driver.PageSource.ToLower(), "An email address required.".ToLower());             
        }
    }
}
