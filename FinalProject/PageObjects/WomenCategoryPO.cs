using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class WomenCategoryPO
    {
        private readonly IWebDriver _driver;

        private By byTopsCheckbox;
        private By bySizeSCheckbox;
        private By byGreenColorCheckbox;
        private By byCottonCheckbox;
        private By byGirlyCheckbox;
        private By byMidiDressCheckbox;
        private By byInStockCheckbox;
        private By byFashionManufacturerCheckbox;
        private By byNewCheckbox;

        public WomenCategoryPO(IWebDriver driver)
        {
            _driver = driver;
            byTopsCheckbox = By.Id("uniform-layered_category_4");
            bySizeSCheckbox = By.Id("uniform-layered_id_attribute_group_1");
            byGreenColorCheckbox = By.Id("layered_id_attribute_group_15");
            byCottonCheckbox = By.Id("uniform-layered_id_feature_5");
            byGirlyCheckbox = By.Id("uniform-layered_id_feature_13");
            byMidiDressCheckbox = By.Id("uniform-layered_id_feature_20");
            byInStockCheckbox = By.Id("uniform-layered_quantity_1");
            byFashionManufacturerCheckbox = By.Id("uniform-layered_manufacturer_1");
            byNewCheckbox = By.Id("uniform-layered_condition_new");
        }

        public void FilterBy(string filter)
        {
            switch (filter)
            {
                case "Tops category":
                    _driver.FindElement(byTopsCheckbox).Click();
                    break;
                case "S size":
                    _driver.FindElement(bySizeSCheckbox).Click();
                    break;
                case "Green color":
                    _driver.FindElement(byGreenColorCheckbox).Click();
                    break;
                case "Cotton composition":
                    _driver.FindElement(byCottonCheckbox).Click();
                    break;
                case "Girly style":
                    _driver.FindElement(byGirlyCheckbox).Click();
                    break;
                case "Midi dress property":
                    _driver.FindElement(byMidiDressCheckbox).Click();
                    break;
                case "In stock availability":
                    _driver.FindElement(byInStockCheckbox).Click();
                    break;
                case "Fashion manufacturer":
                    _driver.FindElement(byFashionManufacturerCheckbox).Click();
                    break;
                case "New condition":
                    _driver.FindElement(byNewCheckbox).Click();
                    break;                
            }
        }
    }
}
