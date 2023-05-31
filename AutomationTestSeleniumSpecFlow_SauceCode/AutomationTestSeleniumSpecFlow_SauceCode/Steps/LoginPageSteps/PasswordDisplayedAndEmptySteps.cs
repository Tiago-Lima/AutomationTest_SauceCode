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
    class PasswordDisplayedAndEmptySteps
    {
        DriverHelper _driverHelper;
        public LoginPage loginPage;

        public PasswordDisplayedAndEmptySteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Then(@"Entao o campo password deve ser exibido vazio")]
        public void EntaoOCampoPasswordDeveSerExibidoVazio()
        {
            Assert.That(loginPage.passwordFieldDisplayed, Is.True);
            Assert.That(loginPage.passwordFieldIsEmpty, Is.True);
        }
    }
}
