using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestSeleniumSpecFlow_SauceCode
{
    
    public class LoginPage
    {
        public IWebDriver _driver;
        public LoginPage()
        {

            _driver = new ChromeDriver("@C:/driverChrome");

        }

        public IWebElement loginFullPage => _driver.FindElement(By.Id("root"));
        public bool loginDisplayed() => loginFullPage.Displayed;

 
    }
}