using FinalProject.Hooks;
using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class ForgotPasswordPO
    {
        private IWebDriver _driver;

        private By byEmailInput;
        private By byRetrievePasswordButton;

        public ForgotPasswordPO(IWebDriver driver)
        {
            _driver = driver;
            byEmailInput = By.Id("email");
            byRetrievePasswordButton = By.CssSelector("button.button-medium");
        }

        public void InsertEmail(string email)
        {
            _driver.FindElement(byEmailInput).SendKeys(email);
        }

        public void ClickRetrievePasswordButton()
        {
            _driver.FindElement(byRetrievePasswordButton).Click();
        }
    }
}
