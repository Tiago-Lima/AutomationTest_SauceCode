using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Pages
{
    class HomePage
    {
        IWebDriver _driver;
        public WebDriverWait wait;  


        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }

        public IWebElement menuButton => _driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement menuItemInventory => _driver.FindElement(By.Id("inventory_sidebar_link"));
        public IWebElement menuItemAbout => _driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement menuItemLogout => _driver.FindElement(By.Id("logout_sidebar_link"));
        public IWebElement menuItemReset => _driver.FindElement(By.Id("reset_sidebar_link"));
        public IWebElement closeMenuButton => _driver.FindElement(By.Id("react-burger-cross-btn"));
        public IWebElement containerItensMenu => _driver.FindElement(By.ClassName("bm-menu"));

        public IList<IWebElement> inventoryList => _driver.FindElements(By.ClassName("inventory_item"));

        public IWebElement cartButton => _driver.FindElement(By.ClassName("shopping_cart_link"));
        public IWebElement cartButtonBadge => _driver.FindElement(By.ClassName("shopping_cart_badge"));


        public int GetTamanhoDaListaInventory(IList<IWebElement> inventory)
        {
            return inventory.Count;
        }

        
        public bool menuButtonDisplayed() => menuButton.Displayed;
        public bool menuButtonIsEnabled() => menuButton.Enabled;
        public bool menuItemAboutDisplayed() => menuItemAbout.Displayed;

        public bool closeMenuButtonDisplayed() => closeMenuButton.Displayed;
        public bool containerMenuDisplayed() => containerItensMenu.Displayed;

        public void ClickCloseMenu()
        {
            esperar();
            closeMenuButton.Click();
        }

        public void esperar()
        {
            wait.Until(driver => { System.Threading.Thread.Sleep(3000); return true; });
        }

      
    }
}
