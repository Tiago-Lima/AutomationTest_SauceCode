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
    class MenuItemAboutClickSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public MenuItemAboutClickSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);

        }

        [When(@"E a opcao About for clicada")]
        public void EAOpcaoAboutForClicada()
        {
            homePage.menuItemAbout.Click();
        }

        [Then(@"Entao a pagina da secao sobre deve ser carregada")]
        public void EntaoAPaginaDaSecaoSobreDeveSerCarregada()
        {
            Assert.AreEqual("https://saucelabs.com/", _driverHelper.Driver.Url);
        }

    }
}
