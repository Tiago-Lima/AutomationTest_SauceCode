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
    class LoginButtonDisplayedAndEmpitySteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;

        public LoginButtonDisplayedAndEmpitySteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver); 
        }

        [Then(@"Entao o botao de login deve ser exibido e estar habilitado")]
        public void EntaoOBotaoDeLoginDeveSerExibidoEEstarHabilitado()
        {
            Assert.That(loginPage.loginButtonDisplayed, Is.True);
            Assert.That(loginPage.loginButtonEnabled, Is.True);
        }
    }
}
