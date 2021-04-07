using OpenQA.Selenium;

namespace FinalProject.PageObjects
{
    public class CreateAccountPO
    {
        private IWebDriver _driver;

        private By byInputFirstName;
        private By byInputLastName;
        private By byInputPassword;
        private By byInputFirstNameAddress;
        private By byInputLastNameAddress;
        private By byInputAddress;
        private By byInputCity;
        private By byInputState;
        private By byInputPostalCode;
        private By byInputCountry;
        private By byInputMobilePhone;
        private By byRegisterButton;        

        public CreateAccountPO(IWebDriver driver)
        {
            _driver = driver;
            byInputFirstName = By.Id("customer_firstname");
            byInputLastName = By.Id("customer_lastname");
            byInputPassword = By.Id("passwd");
            byInputFirstNameAddress = By.Id("firstname");
            byInputLastNameAddress = By.Id("lastname");
            byInputAddress = By.Id("address1");
            byInputCity = By.Id("city");
            byInputState = By.Id("id_state");
            byInputPostalCode = By.Id("postcode");
            byInputCountry = By.Id("id_country");
            byInputMobilePhone = By.Id("phone_mobile");
            byRegisterButton = By.Id("submitAccount");            
        }

        public void InsertFirstName(string firstName)
        {
            _driver.FindElement(byInputFirstName).SendKeys(firstName);
        }

        public void InsertLastName(string lastName)
        {
            _driver.FindElement(byInputLastName).SendKeys(lastName);
        }

        public void InsertPassword(string password)
        {
            _driver.FindElement(byInputPassword).SendKeys(password);
        }

        public void InsertFirstNameAddress(string firstNameAddress)
        {
            _driver.FindElement(byInputFirstNameAddress).SendKeys(firstNameAddress);
        }

        public void InsertLastNameAddress(string lastNameAddress)
        {
            _driver.FindElement(byInputLastNameAddress).SendKeys(lastNameAddress);
        }

        public void InsertAddress(string address)
        {
            _driver.FindElement(byInputAddress).SendKeys(address);
        }

        public void InsertCity(string city)
        {
            _driver.FindElement(byInputCity).SendKeys(city);
        }

        public void InsertState(string state)   // select
        {
            _driver.FindElement(byInputState).SendKeys(state);
        }

        public void InsertPostalCode(string postalCode)
        {
            _driver.FindElement(byInputPostalCode).SendKeys(postalCode);
        }

        public void InsertCountry(string country)  // select
        {
            _driver.FindElement(byInputCountry).SendKeys(country);
        }

        public void InsertMobilePhone(string mobilePhone)
        {
            _driver.FindElement(byInputMobilePhone).SendKeys(mobilePhone);
        }

        public void ClickRegisterButton()
        {
            _driver.FindElement(byRegisterButton).Click();
        }       
    }
}
