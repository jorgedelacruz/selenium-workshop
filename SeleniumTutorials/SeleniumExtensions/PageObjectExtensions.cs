using OpenQA.Selenium;
using SeleniumHelpers.Common;
using System;
using System.Linq;

namespace SeleniumExtensions
{
    public static class PageObjectExtensions
    {
        public static void WaitForScreen(this PageObject page, IWebElement element = null)
        {
            try
            {
                page.WaitForElement(element ?? FindDefaultWaitElement(page));
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException(string.Format("There's no default element to wait for in page object {0}. Either set a default element to wait for, or pass an element to the WaitForScreen method.", page.GetType().Name));
            }
        }

        public static void WaitForElement(this PageObject page, IWebElement element, bool waitForElementVisible = true)
        {
            if (waitForElementVisible) page.Wait.Until(ExpectedCondtions.ElementIsVisible(element));
            else page.Wait.Until(ExpectedCondtions.ElementIsNotVisible(element));
        }

        private static IWebElement FindDefaultWaitElement(PageObject page)
        {
            var allElementsInPageObject = page.GetType().GetProperties(); //group all PO elements as Properties

            var match = allElementsInPageObject.FirstOrDefault(prop => prop.GetCustomAttributes(false).Any(attr => attr.GetType() == typeof(WaitForThisElementAttribute))); //find properties that have the attribute [WaitForThisElement]

            return (IWebElement)match.GetValue(page); //return match
        }
    }
}
