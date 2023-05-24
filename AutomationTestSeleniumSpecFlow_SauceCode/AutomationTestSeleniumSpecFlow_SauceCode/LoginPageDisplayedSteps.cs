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

        public IWebDriver webDriver;
        public LoginPageDisplayedSteps()
        {
            webDriver = new ChromeDriver("@C:/driverChrome");
        }

        [Given(@"I launch the driver and navigate to test site")]
        public void GivenILaunchTheDriverAndNavigateToTestSite()
        {
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then(@"The login page should be displayed")]
        public void ThenTheLoginPageShouldBeDisplayed()
        {
            IWebElement result = webDriver.FindElement(By.Id("root"));
            Assert.IsTrue(result.Displayed);
        }

    }
}
