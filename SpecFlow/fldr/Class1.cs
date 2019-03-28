using OpenQA.Selenium;

namespace SpecFlow.fldr
{
    public class DriverSingleton
    {
        private static IWebDriver driver;
        private DriverSingleton() { }

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory().GetDriver("Chrome");
                }
                return driver;
            }
        }
    }
}
