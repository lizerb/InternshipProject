using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace FinalProject.Hooks
{
    [Binding]
    public sealed class Context
    {
        public IWebDriver Driver { get; private set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--no-sandbox");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("disable-gpu");
            chromeOptions.AddArguments("--disable-notifications");
            chromeOptions.AddExcludedArgument("disable-popup-blocking");
            Driver = new ChromeDriver(chromeOptions);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
