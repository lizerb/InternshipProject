﻿using FinalProject.Hooks;
using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class ForgotPasswordPO
    {
        private IWebDriver _driver;

        private By byInputEmail;
        private By byRetrievePasswordButton;

        public ForgotPasswordPO(Context context)
        {
            _driver = context.Driver;
            byInputEmail = By.Id("email");
            byRetrievePasswordButton = By.CssSelector("button.button-medium");
        }

        public void InsertEmail(string email)
        {
            _driver.FindElement(byInputEmail).SendKeys(email);
        }

        public void ClickRetrievePasswordButton()
        {
            _driver.FindElement(byRetrievePasswordButton).Click();
        }
    }
}
