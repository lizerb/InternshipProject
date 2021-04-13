using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class LoginPO
    {
        private readonly IWebDriver _driver;

        private By byEmailCreateInput;
        private By byEmailInput;
        private By byPasswordInput;
        private By byCreateAccountButton;
        private By bySignInButton;
        private By byForgotPasswordLink;

        public LoginPO(IWebDriver driver)
        {
            _driver = driver;
            byEmailCreateInput = By.Id("email_create");
            byEmailInput = By.Id("email");
            byPasswordInput = By.Id("passwd");
            byCreateAccountButton = By.Id("SubmitCreate");
            bySignInButton = By.Id("SubmitLogin");
            byForgotPasswordLink = By.CssSelector("div>p.lost_password.form-group>a");
        }

        public void InsertEmailCreate(string email)
        {
            _driver.FindElement(byEmailCreateInput).SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            _driver.FindElement(byCreateAccountButton).Click();
        }

        public void InsertEmail(string email)
        {
            _driver.FindElement(byEmailInput).SendKeys(email);
        }

        public void InsertPassword(string password)
        {
            _driver.FindElement(byPasswordInput).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(bySignInButton).Click();
        }

        public void ClickForgotPassword()
        {
            _driver.FindElement(byForgotPasswordLink).Click();
        }
    }
}
