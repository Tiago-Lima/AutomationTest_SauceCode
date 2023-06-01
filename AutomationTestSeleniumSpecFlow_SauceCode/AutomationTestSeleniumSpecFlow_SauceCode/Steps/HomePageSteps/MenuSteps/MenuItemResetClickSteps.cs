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
    class MenuItemResetClickSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public MenuItemResetClickSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [When(@"E a opcao Reset App State for clicada")]
        public void EAOpcaoResetAppStateForClicada()
        {
            homePage.menuItemReset.Click();
        }

        [Then(@"Entao deve mostrar a home page e esvaziar o carrinho")]
        public void EntaoDeveMostrarAHomePageEEsvaziarOCarrinho()
        {
            Assert.AreEqual("https://www.saucedemo.com/inventory.html", _driverHelper.Driver.Url); // Esse teste vai falhar, mas achei que faria mais sentido se a página se comportasse redirecionando pra Home no botão Reset
            Assert.IsFalse(homePage.cartButtonBadge.Displayed); // Esse não é o melhor jeito de testar, o certo seria conferir a lista de itens na página do carrinho. Mas fiz assim como se a página do carrinho ainda não tivesse sido implementada.
        }                                                       // Já que estamos testando as features do menu na homePage. Aqui só está conferindo se o badge que marca a quantidade de itens no carrinho está vazio e invisível.        
    }
}
