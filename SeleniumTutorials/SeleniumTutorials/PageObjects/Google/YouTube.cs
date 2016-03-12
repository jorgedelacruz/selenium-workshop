using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumHelpers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumExtensions;
using System.Threading.Tasks;

namespace SeleniumTutorials.PageObjects.Google
{
    public class YouTube : PageObject
    {
        [WaitForThisElement]
        [FindsBy(How = How.Id, Using = "logo-container")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.Id, Using = "upload-btn")]
        public IWebElement Upload { get; set; }

        public void ClickUpload()
        {
            this.WaitForScreen();
            Upload.Click();
        }
    }
}
