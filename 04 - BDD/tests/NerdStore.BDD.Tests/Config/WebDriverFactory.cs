using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace NerdStore.BDD.Tests.Config
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(Browser browser, string caminhoDriver, bool headless)
        {
            switch (browser)
            {
                case Browser.Firefox:
                    var optionsFireFox = new FirefoxOptions();
                    if (headless)
                        optionsFireFox.AddArgument("--headless");

                    return string.IsNullOrWhiteSpace(caminhoDriver)
                        ? new FirefoxDriver(optionsFireFox)
                        : new FirefoxDriver(caminhoDriver, optionsFireFox);

                case Browser.Chrome:
                    var options = new ChromeOptions();
                    if (headless)
                        options.AddArgument("--headless");

                    return string.IsNullOrWhiteSpace(caminhoDriver)
                        ? new ChromeDriver(options)
                        : new ChromeDriver(caminhoDriver, options);

                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }
        }
    }
}
