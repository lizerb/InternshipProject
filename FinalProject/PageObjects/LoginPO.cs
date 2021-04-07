using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class LoginPO
    {
        private IWebDriver _driver;

        private By byInputEmail;
        private By byCreateAccountButton;

        public LoginPO(IWebDriver driver)
        {
            this._driver = driver;
            byInputEmail = By.Id("email_create");
            byCreateAccountButton = By.Id("SubmitCreate");
        }

        public void InsertEmail(string email)
        {
            _driver.FindElement(byInputEmail).SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            _driver.FindElement(byCreateAccountButton).Click();
        }
    }
}
