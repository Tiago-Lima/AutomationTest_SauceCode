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
    class MenuItemAllitensClickSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public MenuItemAllitensClickSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [When(@"E a opcao All itens for clicada")]
        public void EAOpcaoAllitensForClicada()
        {
            homePage.menuItemInventory.Click();
        }

        [Then(@"Entao deve mostrar a home page com todos os itens")]
        public void EntaoDeveMostrarAHomePageComTodosOsItens()
        {
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", _driverHelper.Driver.Url);

            var result = homePage.GetTamanhoDaListaInventory(homePage.inventoryList);
            Console.WriteLine("O Resultado é " + result +"itens");
            
            Assert.IsTrue(result >= 6);
        }
    }
}
