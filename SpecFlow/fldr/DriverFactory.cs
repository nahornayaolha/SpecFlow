using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SpecFlow.fldr
{
    class DriverFactory
    {
        public IWebDriver GetDriver(string driverType)
        {
            IWebDriver driver;

            switch (driverType)
            {
                case "Chrome":
                    {
                        driver = new ChromeDriver();
                    }
                    break;
                case "Firefox":
                    {
                        driver = new FirefoxDriver();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(driverType, @"Such driver does not support");
            }
            return driver;
        }
    }
}
