using FinalProject.Hooks;
using FinalProject.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class ForgotPasswordSteps
    {
        private readonly IWebDriver _driver;

        private readonly HomePO homePO;
        private readonly LoginPO loginPO;
        private readonly ForgotPasswordPO forgotPasswordPO;

        public ForgotPasswordSteps(Context context)
        {
            _driver = context.Driver;
            homePO = new HomePO(_driver);
            loginPO = new LoginPO(_driver);
            forgotPasswordPO = new ForgotPasswordPO(_driver);
        }

        [Given(@"that I am a customer who has a registration")]
        public void GivenThatIAmACustomerWhoHasARegistration()
        {
            homePO.Visit();
        }
        
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            homePO.ClickSignInButton();
        }
        
        [When(@"I click in forgot my password")]
        public void WhenIClickInForgotMyPassword()
        {
            loginPO.ClickForgotPassword();
        }
        
        [When(@"I inform my registered email")]
        public void WhenIInformMyRegisteredEmail()
        {
            forgotPasswordPO.InsertEmail("janedoe@hotmail.com");
            forgotPasswordPO.ClickRetrievePasswordButton();
        }
        
        [When(@"I inform an email that is not registered in the website")]
        public void WhenIInformAnEmailThatIsNotRegisteredInTheWebsite()
        {
            forgotPasswordPO.InsertEmail("unregistered@hotmail.com");
            forgotPasswordPO.ClickRetrievePasswordButton();
        }
        
        [When(@"I inform an invalid email")]
        public void WhenIInformAnInvalidEmail()
        {
            forgotPasswordPO.InsertEmail("invalidemail");
            forgotPasswordPO.ClickRetrievePasswordButton();
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string message)
        {            
            _driver.PageSource.Should().Contain(message);
        }
    }
}
