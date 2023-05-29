using AutomationTestSeleniumSpecFlow_SauceCode;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class LoginPageDisplayedSteps 
    {

        DriverHelper _driverHelper;
        public LoginPage loginPage;
        public LoginPageDisplayedSteps(DriverHelper driver)
        {
            _driverHelper = driver;
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        [Given(@"Dado que o navegador seja aberto no site")]
        public void DadoQueONavegadorSejaAbertoNoSite()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then(@"Entao a pagina de login deve ser exibida")]
        public void EntaoAPaginaDeLoginDeveSerExibida()
        {
            
            Assert.IsTrue(loginPage.loginPageDisplayed());
        }

    }
}
