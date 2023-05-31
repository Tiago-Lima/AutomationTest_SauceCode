using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationTestSeleniumSpecFlow_SauceCode.Hooks
{
    [Binding]
    class Hooks : DriverHelper
    {
        DriverHelper _driverHelper;
              
        public Hooks(DriverHelper driver)
        {
            _driverHelper = driver;
           
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            _driverHelper.Driver = new ChromeDriver(@"C:\chromeDriver");

        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
