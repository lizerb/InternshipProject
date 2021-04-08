using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class LoginPO
    {
        private readonly IWebDriver _driver;

        private By byInputEmailCreate;
        private By byInputEmail;
        private By byInputPassword;
        private By byCreateAccountButton;
        private By bySignInButton;

        public LoginPO(IWebDriver driver)
        {
            _driver = driver;
            byInputEmailCreate = By.Id("email_create");
            byInputEmail = By.Id("email");
            byInputPassword = By.Id("passwd");
            byCreateAccountButton = By.Id("SubmitCreate");
            bySignInButton = By.Id("SubmitLogin");
        }

        public void InsertEmailCreate(string email)
        {
            _driver.FindElement(byInputEmailCreate).SendKeys(email);
        }

        public void ClickCreateAccountButton()
        {
            _driver.FindElement(byCreateAccountButton).Click();
        }

        public void InsertEmail(string email)
        {
            _driver.FindElement(byInputEmail).SendKeys(email);
        }

        public void InsertPassword(string password)
        {
            _driver.FindElement(byInputPassword).SendKeys(password);
        }

        public void ClickSignInButton()
        {
            _driver.FindElement(bySignInButton).Click();
        }
    }
}
