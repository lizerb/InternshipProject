using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class HomePO
    {
        private readonly IWebDriver _driver;
        private By bySignInButton;
        private By bySearchInput;
        private By bySearchButton;

        public HomePO(IWebDriver driver)
        {
            _driver = driver;
            bySignInButton = By.ClassName("login");
            bySearchInput = By.Id("search_query_top");
            bySearchButton = By.Name("submit_search");
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(bySignInButton).Click();
        }

        public void InsertItemToSearch(string item)
        {
            _driver.FindElement(bySearchInput).SendKeys(item);
        }
        
        public void ClickSearchButton()
        {
            _driver.FindElement(bySearchButton).Click();
        }
    }
}
