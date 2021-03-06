﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumHelpers.Common;

namespace SeleniumTutorials.PageObjects
{
    public class ManageAccount : PageObject
    {
        [FindsBy(How = How.Id, Using = "")]
        public IWebElement btnEditUser { get; set; }
    }
}
