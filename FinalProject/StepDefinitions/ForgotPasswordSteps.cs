using System;
using TechTalk.SpecFlow;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class ForgotPasswordSteps
    {
        [Given(@"that I am a customer who has a registration")]
        public void GivenThatIAmACustomerWhoHasARegistration()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click in forgot my password")]
        public void WhenIClickInForgotMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I inform my registered email")]
        public void WhenIInformMyRegisteredEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I inform an email that is not registered in the website")]
        public void WhenIInformAnEmailThatIsNotRegisteredInTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I inform an invalid email")]
        public void WhenIInformAnInvalidEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a message informing (.*) is shown")]
        public void ThenAMessageInformingIsShown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
