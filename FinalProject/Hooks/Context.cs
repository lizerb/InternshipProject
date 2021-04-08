using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using FinalProject.Helpers;

namespace FinalProject.Hooks
{
    public class Context : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        
        public Context()
        {            
            Driver = new ChromeDriver(TestHelper.ExeFolder);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
