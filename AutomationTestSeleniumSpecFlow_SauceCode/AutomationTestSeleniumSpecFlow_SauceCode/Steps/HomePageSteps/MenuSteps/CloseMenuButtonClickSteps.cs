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
    class CloseMenuButtonClickSteps
    {
        DriverHelper _driverHelper;
        public HomePage homePage;

        public CloseMenuButtonClickSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [When(@"E o botao de fechar o menu for clicado")]
        public void  EOBotaoDeFecharOMenoForClicado()
        {
            homePage.ClickCloseMenu();
        }

        [Then(@"Entao os itens devem ser ocultados e o botao de menu deve ser exibido habilitado na pagina principal")]
        public void EntaoOsItensDevemSerOcultados()
        {
            homePage.esperar();
            Assert.That(homePage.closeMenuButtonDisplayed, Is.False);
            

            var screenshot = ((ITakesScreenshot)_driverHelper.Driver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\tiago\Desktop\Workspace\AutomationTest_SauceCode\Evidencias\closeMenuEvidence.png", ScreenshotImageFormat.Png);
        }
    }
}
