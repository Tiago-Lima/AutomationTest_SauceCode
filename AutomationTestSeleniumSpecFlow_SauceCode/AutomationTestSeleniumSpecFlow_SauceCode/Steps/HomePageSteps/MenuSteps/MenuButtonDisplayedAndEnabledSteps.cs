using AutomationTestSeleniumSpecFlow_SauceCode.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Steps.HomePageSteps.MenuSteps
{
    [Binding]
    class MenuButtonDisplayedAndEnabledSteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;
        public HomePage homePage;

        public MenuButtonDisplayedAndEnabledSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);
            homePage = new HomePage(_driverHelper.Driver);
        }

        [Given(@"E o usuario esteja logado")]
        public void EOUsuarioEstejaLogado()
        {
            loginPage.login("standard_user", "secret_sauce");
            loginPage.submitLogin();
        }

        [When(@"Quando A HomePage estiver carregada")]
        public void QuandoAHomePageEstiverCarregada()
        {
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", _driverHelper.Driver.Url);
           
        }

        [Then(@"Entao o botao de menu deve ser exibido habilitado")]
        public void EntaoOBotaoDeMenuDeveSerExibidoHabilitado()
        {
            Assert.That(homePage.menuButtonDisplayed, Is.True);
            Assert.That(homePage.menuButtonIsEnabled, Is.True);
        }
    }
}
