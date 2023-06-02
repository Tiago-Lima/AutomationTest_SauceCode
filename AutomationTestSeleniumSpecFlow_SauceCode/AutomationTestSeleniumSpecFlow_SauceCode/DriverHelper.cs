using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestSeleniumSpecFlow_SauceCode
{
    public class DriverHelper
    {
        public IWebDriver Driver { get; set; }

        /*  public DriverHelper()
          {
              ChromeOptions chromeOptions = new ChromeOptions();                                                                      // Quando eu passo o mesmo caminho do driver da instancia na classe Hooks.cs o driver não funciona, mas´passando a string
              // Configurações adicionais, se necessário                                                                              // direto assim funciona.
              var caminhoChromeDriver = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";                               // Passando o caminho do meu executável do chrome desta forma funciona. Mas é muito mais lento e não mostra
              chromeOptions.BinaryLocation = caminhoChromeDriver;                                                                     // a página executando os comandos :(   
              chromeOptions.AddArgument("--single-process");


              ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(caminhoChromeDriver);
              chromeDriverService.InitializationTimeout = TimeSpan.FromSeconds(30);
              // Configurações adicionais, se necessário

              Driver = new ChromeDriver(chromeDriverService, chromeOptions);
          }
        */
    }
}
