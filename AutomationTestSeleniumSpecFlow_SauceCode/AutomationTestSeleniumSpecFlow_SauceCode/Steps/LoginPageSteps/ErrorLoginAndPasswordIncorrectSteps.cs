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
    class ErrorLoginAndPasswordIncorrectSteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;

        public ErrorLoginAndPasswordIncorrectSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Given(@"E o campo login e password sao invalidos")]
        public void EOCampoLoginEPasswordSaoIncorretos()
        {
            loginPage.login("huasduhas", "senha123"); // Login e senha incorretos
        }

        [When(@"Quando o botao de login for pressionado")]
        public void QuandoOBotaoDeLoginForPressionado()
        {
            loginPage.submitLogin();
        }

        [Then(@"Entao deve ser exibido a mensagem de erro correta")]
        public void EntaoDeveSerExibidoAMensagemDeErroCorreta()
        {
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", loginPage.errorMsg.Text); // Mensagem de erro especificada para este cenário
        }

    }
}
