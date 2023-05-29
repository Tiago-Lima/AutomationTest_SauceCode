using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestSeleniumSpecFlow_SauceCode
{
    
    public class LoginPage
    {
        IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement loginFullPage => _driver.FindElement(By.Id("root"));
        public IWebElement usernameField => _driver.FindElement(By.Id("user-name"));
        public IWebElement passwordField => _driver.FindElement(By.Id("password"));
        public IWebElement loginButton => _driver.FindElement(By.Id("login-button")); 
        public bool loginPageDisplayed() => loginFullPage.Displayed;
        public bool usernameFieldDisplayed() => usernameField.Displayed;
        public bool usernameFieldIsEmpty() => usernameField.Text.Length == 0;
        public bool passwordFieldDisplayed() => passwordField.Displayed;
        public bool passwordFieldIsEmpty() => passwordField.Text.Length == 0;
        public bool loginButtonDisplayed() => loginButton.Displayed;
        public bool loginButtonEnabled() => loginButton.Enabled;

 
    }
}