using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExtensions
{
    public class ExpectedCondtions
    {
        public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        public static Func<IWebDriver, bool> ElementIsNotVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return !element.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }
    }
}
