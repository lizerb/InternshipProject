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
        private readonly CreateAccountPO = new CreateAccountPO(_driver);

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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I access the Sign in page")]
        public void WhenIAccessTheSignInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I don't fill at least one of the mandatory fields of the registration form")]
        public void WhenIDonTFillAtLeastOneOfTheMandatoryFieldsOfTheRegistrationForm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be redirected to the login page")]
        public void ThenIWillBeRedirectedToTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will be redirected to the registration page")]
        public void ThenIWillBeRedirectedToTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to finish my registration in the online store")]
        public void ThenIShouldBeAbleToFinishMyRegistrationInTheOnlineStore()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a message must be shown saying that all the mandatory fields must be informed")]
        public void ThenAMessageMustBeShownSayingThatAllTheMandatoryFieldsMustBeInformed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
