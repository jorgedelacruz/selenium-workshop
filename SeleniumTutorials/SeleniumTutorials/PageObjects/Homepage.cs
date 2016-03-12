using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumTutorials.Common;

namespace SeleniumTutorials.PageObjects
{
    public class Homepage : PageObject
    {
        [FindsBy(How = How.Id)]
        public IWebElement txtLogedUserCarret { get; set; }

        [FindsBy(How = How.Id)]
        public IWebElement txtLogedUsername { get; set; }

        [FindsBy(How = How.Id)]
        public IWebElement btnLogoff { get; set; }

        [FindsBy(How = How.Id)]
        public IWebElement btnManageAccount { get; set; }

        public ManageAccount GoToManageAccount()
        {
            txtLogedUserCarret.Click();
            btnManageAccount.Click();
            return WebDriver.GetPage<ManageAccount>();
        }
    }
}
