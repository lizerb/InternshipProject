using FinalProject.Hooks;
using FinalProject.PageObjects;
using FluentAssertions;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using FinalProject.Screenshot;

namespace FinalProject.StepDefinitions
{
    [Binding]
    public class FilterProductsSteps
    {
        private readonly IWebDriver _driver;
        private Screenshots _screenshots;
        private readonly HomePO homePO;
        private readonly WomenCategoryPO womenCategoryPO;

        public FilterProductsSteps(Context context)
        {
            _driver = context.Driver;
            _screenshots = new Screenshots(_driver);
            homePO = new HomePO(_driver);
            womenCategoryPO = new WomenCategoryPO(_driver);            
        }

        [Given(@"that I am a user at Home page")]
        public void GivenThatIAmAUserAtHomePage()
        {
            homePO.Visit();
        }
        
        [Given(@"that I am a user at Women category page")]
        public void GivenThatIAmAUserAtWomenCategoryPage()
        {
            homePO.Visit();
            homePO.ClickWomenButton();
        }
        
        [When(@"I choose Women category")]
        public void WhenIChooseWomenCategory()
        {
            homePO.ClickWomenButton();
        }
        
        [When(@"I choose to filter by ""(.*)""")]
        public void WhenIChooseToFilterBy(string filter)
        {
            womenCategoryPO.FilterBy(filter);
            Thread.Sleep(7000);        // in order to see if the correct filter was selected
            _screenshots.ToImage();
        }
        
        [Then(@"I will be redirected to the Women category page")]
        public void ThenIWillBeRedirectedToTheWomenCategoryPage()
        {
            _driver.Title.Should().Be("Women - My Store");
            _driver.FindElement(By.CssSelector("div.content_scene_cat_bg"));
        }

        [Then(@"I will see ""(.*)"" at results page")]
        public void ThenIWillSeeAtResultsPage(string message)
        {
            _driver.PageSource.Should().Contain(message);
        }
    }
}
