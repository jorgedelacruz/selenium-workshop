using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumHelpers.Common;
using System;
using SeleniumExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTutorials.Common;

namespace SeleniumTutorials.PageObjects.Google
{
    public class HomeScreen : PageObject
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement Omnibox { get; set; }

        [WaitForThisElement]
        [FindsBy(How = How.Id, Using = "hplogo")]
        public IWebElement Logo { get; set; }
        
        public HomeScreen Search(string query)
        {
            this.WaitForElement(Logo);
            Omnibox.SendKeys(query);
            Omnibox.Submit();
            return this;
        }

    }
}
