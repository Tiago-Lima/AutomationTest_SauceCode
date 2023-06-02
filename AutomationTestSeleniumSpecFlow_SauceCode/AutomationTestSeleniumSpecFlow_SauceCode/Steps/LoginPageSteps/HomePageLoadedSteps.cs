using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Steps
{
    [Binding]
    class HomePageLoadedSteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;

        public HomePageLoadedSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Given(@"E o campo login e password estao corretos")]
        public void EOCampoLoginEPasswordEstaoCorretos()
        {
            loginPage.login("standard_user", "secret_sauce");
        }

        [Then(@"Entao a pagina inventory deve ser carregada")]
        public void EntaoAPaginaInventoryDeveSerCarregada()
        {
            var screenshot = ((ITakesScreenshot)_driverHelper.Driver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\tiago\Desktop\Workspace\AutomationTest_SauceCode\Evidencias\homePageLoaded.png", ScreenshotImageFormat.Png);

            Assert.AreEqual("https://www.saucedemo.com/inventory.html", _driverHelper.Driver.Url);
        }
    }
}
