using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumTutorials.PageObjects;
using System;

namespace SeleniumTutorials.Common
{
    public static class WebDriver
    {
        private static IWebDriver driver;

        public static Login Login
        {
            get
            {
                return GetPage<Login>();
            }
        }

        public static Homepage Homepage
        {
            get
            {
                return GetPage<Homepage>();
            }
        }

        public static void InitDriver<T>(Uri page) where T : IWebDriver
        {
            driver = Activator.CreateInstance<T>();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(page);
        }

        private static void EnsureDriver()
        {
            if (driver == null)
                throw new Exception("Make sure to initialize the WebDriver using 'InitDriver<T>()' method");
        }

        public static T GetPage<T>() where T : PageObject
        {
            EnsureDriver();
            var instance = Activator.CreateInstance<T>();
            PageFactory.InitElements(driver, instance);
            instance.Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 0, 5));

            return instance;
        }
    }
}
