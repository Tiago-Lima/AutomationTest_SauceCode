using NUnit.Framework;
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
            Assert.AreEqual("Epic sadface: Username is required", loginPage.errorMsg.Text);
        }

    }
}
