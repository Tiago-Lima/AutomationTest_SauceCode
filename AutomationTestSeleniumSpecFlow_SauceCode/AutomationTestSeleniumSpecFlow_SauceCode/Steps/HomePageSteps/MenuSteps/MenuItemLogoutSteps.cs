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
    class MenuItemLogoutSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public MenuItemLogoutSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [When(@"E a opcao Logout for clicada")]
        public void EAOpcaoLogoutForClicada()
        {
            homePage.menuItemLogout.Click();
        }

        [Then(@"Entao deve retornar para a pagina de login")]
        public void EntaoDeveRetornarParaPaginaDeLogin()
        {
            Assert.AreEqual("https://www.saucedemo.com/", _driverHelper.Driver.Url);
        }
    }
}
