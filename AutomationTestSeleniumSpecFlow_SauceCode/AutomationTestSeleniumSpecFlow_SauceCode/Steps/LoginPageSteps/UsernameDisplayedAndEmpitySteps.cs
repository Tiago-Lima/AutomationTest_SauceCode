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
    class UsernameDisplayedAndEmpitySteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;

        public UsernameDisplayedAndEmpitySteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);

        }

        [Then(@"Entao o campo username deve ser exibido vazio")]
        public void EntaoOCampoUsernameDeveSerExibidoVazio()
        {
            Assert.That(loginPage.usernameFieldDisplayed, Is.True);
            Assert.That(loginPage.usernameFieldIsEmpty, Is.True);
        }
    }
}
