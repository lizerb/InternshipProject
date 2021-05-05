using OpenQA.Selenium;
using System.Threading;

namespace FinalProject.Screenshot
{
    public class Screenshots
    {
        private readonly IWebDriver _driver;
        public string screenshotsFile;
        private int _count = 1;

        public Screenshots(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Screenshot(IWebDriver driver, string file)
        {
            ITakesScreenshot print = driver as ITakesScreenshot;
            var picture = print.GetScreenshot();
            picture.SaveAsFile(file, ScreenshotImageFormat.Png);
        }

        public void ToImage()
        {
            screenshotsFile = @"C:\Users\marlize.batista\source\repos\FinalProject\screenshot\";
            Screenshot(_driver, screenshotsFile + "Image_" + _count++ + ".png");
            Thread.Sleep(1000);
        }
    }
}
