using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHelpers;
using SeleniumHelpers.Common;
using SeleniumTutorials.PageObjects.Google;
using System;

namespace SeleniumTutorials.Common
{
    public class MyDriver : SUTDriver
    {
        public static void Initialize(string address = null)
        {
            InitDriver<ChromeDriver>(new Uri(address ?? ""));
        }

        public static HomeScreen HomeScreen
        {
            get
            {
                return GetPage<HomeScreen>();
            }
        }

        public static SearchResults SearchResults
        {
            get
            {
                return GetPage<SearchResults>();
            }
        }

        public static YouTube YouTube
        {
            get
            {
                return GetPage<YouTube>();
            }
        }
    }
}
