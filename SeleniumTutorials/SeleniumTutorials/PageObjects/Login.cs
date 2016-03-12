using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumHelpers.Common;
using SeleniumTutorials.Common;
using SeleniumTutorials.DataTypes;

namespace SeleniumTutorials.PageObjects
{
    public class Login : PageObject
    {
        [FindsBy(How = How.Id)]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id)]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id)]
        public IWebElement btnLogin { get; set; }

        public Login EnterCredentials(UserCredentials credentials)
        {
            txtUsername.SendKeys(credentials.Username);
            txtPassword.SendKeys(credentials.Password);
            return this;
        }

        public Homepage SubmitLoginForm()
        {
            btnLogin.Click();
            return MyDriver.GetPage<Homepage>();
        }
    }
}
