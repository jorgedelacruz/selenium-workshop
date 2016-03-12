using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumHelpers.Common;
using SeleniumExtensions;

namespace SeleniumTutorials.PageObjects.Google
{
    public class SearchResults : PageObject
    {
        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement Logo { get; set; }

        [WaitForThisElement]
        [FindsBy(How = How.LinkText, Using = "YouTube")]
        public IWebElement FirstResult { get; set; }

        public SearchResults OpenFirstResult()
        {
            this.WaitForScreen();
            FirstResult.Click();
            return this;
        }
    }
}
