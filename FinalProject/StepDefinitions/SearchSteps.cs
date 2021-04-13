using FinalProject.PageObjects;
using FinalProject.Hooks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
        private IWebDriver _driver;
        private HomePO homePO;

        public SearchSteps(Context context)
        {
            _driver = context.Driver;
            homePO = new HomePO(_driver);
        }

        [Given(@"that I am a customer browsing in the website")]
        public void GivenThatIAmACustomerBrowsingInTheWebsite()
        {
            homePO.Visit();
        }
        
        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string product)
        {
            homePO.InsertProductToSearch(product);
            homePO.ClickSearchButton();
        }
        
        [Then(@"I will be redirected to the results page")]
        public void ThenIWillBeRedirectedToTheResultsPage()
        {
            _driver.PageSource.Should().Contain("1 result has been found");
        }
        
        [Then(@"the the message ""(.*)"" is shown")]
        public void ThenTheTheMessageIsShown(string message)
        {
            _driver.PageSource.Should().Contain(message);
        }
    }
}
