using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumHelpers.Common;
using System;

namespace SeleniumHelpers
{
    public class SUTDriver
    {
        public static IWebDriver Driver;
        //public static DriverOptions DriverOptions;

        public static void InitDriver<T>(Uri page) where T : IWebDriver
        {
            Driver = Activator.CreateInstance<T>();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(page);
        }

        private static void EnsureDriver()
        {
            if (Driver == null)
                throw new Exception("Make sure to initialize the WebDriver using 'InitDriver<T>()' method");
        }

        public static T GetPage<T>() where T : PageObject
        {
            EnsureDriver();
            var instance = Activator.CreateInstance<T>();
            PageFactory.InitElements(Driver, instance);
            instance.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            return instance;
        }
    }
}
