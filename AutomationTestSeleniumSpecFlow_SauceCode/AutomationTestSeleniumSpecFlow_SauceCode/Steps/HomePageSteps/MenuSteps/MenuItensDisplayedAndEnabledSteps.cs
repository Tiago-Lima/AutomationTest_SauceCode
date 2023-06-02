using AutomationTestSeleniumSpecFlow_SauceCode.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Steps.HomePageSteps.MenuSteps
{
    [Binding]
    class MenuItensDisplayedAndEnabledSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public MenuItensDisplayedAndEnabledSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [When(@"E o Menu for acionado")]
        public void EOMenuForAcionado()
        {
            homePage.menuButton.Click();
        }

        [Then(@"Entao os itens devem aparecer habilitados")]
        public void EntaoOsItensDevemAparecerHabilitados()
        {
           
            Assert.IsTrue(homePage.menuItemAbout.Displayed);
            Assert.IsTrue(homePage.menuItemAbout.Enabled);
            Assert.IsTrue(homePage.menuItemInventory.Displayed);
            Assert.IsTrue(homePage.menuItemInventory.Enabled);
            Assert.IsTrue(homePage.menuItemLogout.Displayed);
            Assert.IsTrue(homePage.menuItemLogout.Enabled);
            Assert.IsTrue(homePage.menuItemReset.Displayed);
            Assert.IsTrue(homePage.menuItemReset.Enabled);
            Assert.IsTrue(homePage.closeMenuButton.Displayed);
            Assert.IsTrue(homePage.closeMenuButton.Enabled);

            var screenshot = ((ITakesScreenshot)_driverHelper.Driver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\tiago\Desktop\Workspace\AutomationTest_SauceCode\Evidencias\menuItensDisplayed.png", ScreenshotImageFormat.Png);
        }
    }
}
