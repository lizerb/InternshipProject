using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class HomePO
    {
        private IWebDriver _driver;
        private By bySignInButton;

        public HomePO(IWebDriver driver)
        {
            _driver = driver;
            bySignInButton = By.ClassName("login");
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(bySignInButton).Click();
        }
    }
}
