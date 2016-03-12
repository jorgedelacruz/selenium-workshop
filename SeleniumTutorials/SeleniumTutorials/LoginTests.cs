using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.IE;
using SeleniumTutorials.Common;
using OpenQA.Selenium.Chrome;
using SeleniumTutorials.DataTypes;

namespace SeleniumTutorials
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Login_UsingValidCredentials_ResultsHomepage()
        {
            UserCredentials validCredentials = new UserCredentials { Username = "jcruzz92@gmail.com", Password = "asdasd" };

            WebDriver.InitDriver<ChromeDriver>(new Uri("http://www.deliveriando.com.do"));
            WebDriver.Login.EnterCredentials(validCredentials).SubmitLoginForm();
            Assert.AreEqual<bool>(true, WebDriver.Homepage.txtLogedUserCarret.Displayed);

            WebDriver.Homepage.GoToManageAccount();
        }
    }
}
