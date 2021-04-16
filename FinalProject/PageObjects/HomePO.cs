using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class HomePO
    {
        private readonly IWebDriver _driver;
        private By bySignInButton;
        private By bySearchInput;
        private By bySearchButton;
        private By byWomenButton;

        public HomePO(IWebDriver driver)
        {
            _driver = driver;
            bySignInButton = By.ClassName("login");
            bySearchInput = By.Id("search_query_top");
            bySearchButton = By.Name("submit_search");
            byWomenButton = By.CssSelector("ul>li:nth-child(1)>a"); 
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(bySignInButton).Click();
        }

        public void InsertProductToSearch(string product)
        {
            _driver.FindElement(bySearchInput).SendKeys(product);
        }
        
        public void ClickSearchButton()
        {
            _driver.FindElement(bySearchButton).Click();
        }

        public void ClickWomenButton()
        {
            _driver.FindElement(byWomenButton).Click();
        }
    }
}
