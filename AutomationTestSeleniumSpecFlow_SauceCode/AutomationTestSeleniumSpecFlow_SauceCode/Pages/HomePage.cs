using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Pages
{
    class HomePage
    {
        IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement menuButton => _driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement menuItemInventory => _driver.FindElement(By.Id("inventory_sidebar_link"));
        public IWebElement menuItemAbout => _driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement menuItemLogout => _driver.FindElement(By.Id("logout_sidebar_link"));
        public IWebElement menuItemReset => _driver.FindElement(By.Id("reset_sidebar_link"));
        public IWebElement closeMenuButton => _driver.FindElement(By.Id("react-burger-cross-btn"));

        public bool menuButtonDisplayed() => menuButton.Displayed;
        public bool menuButtonIsEnabled() => menuButton.Enabled;

      
    }
}
