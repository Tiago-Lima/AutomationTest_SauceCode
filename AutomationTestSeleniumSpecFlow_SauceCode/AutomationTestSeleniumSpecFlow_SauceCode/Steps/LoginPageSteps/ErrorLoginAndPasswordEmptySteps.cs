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
    class ErrorLoginAndPasswordEmptySteps
    {
        DriverHelper _driver;
        public LoginPage loginPage;

        public ErrorLoginAndPasswordEmptySteps(DriverHelper driver)
        {
            _driver = driver;
            loginPage = new LoginPage(_driver.Driver);
        }

        [Given(@"E o campo login e password estao vazios")]
        public void EOCampoLoginEPasswordEstaoVazios()
        {
            loginPage.login("", "");
        }

        [Then(@"Entao deve ser exibido a mensagem de erro para campos vazios")]
        public void EntaoDeveSerExibidoAMensagemDeErroParaCamposVazios()
        {
            var screenshot = ((ITakesScreenshot)_driver.Driver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\tiago\Desktop\Workspace\AutomationTest_SauceCode\Evidencias\error_loginAndPasswordEmpty.png", ScreenshotImageFormat.Png);
            Assert.AreEqual("Epic sadface: Username is required", loginPage.errorMsg.Text);
        }

    }
}
