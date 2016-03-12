using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTutorials.Common;
using SeleniumExtensions;
using System;

namespace SeleniumTutorials
{
    [TestClass]
    public class GoogleTests : MasterTestClass
    {
        [TestMethod]
        public void OpenGoogle_SearcYoutube_OpenYoutube_WaitForLogo()
        {
            MyDriver.Initialize("http://www.google.com.do");
            MyDriver.HomeScreen.Search("youtube");
            MyDriver.SearchResults.OpenFirstResult();
            MyDriver.YouTube.ClickUpload();
        }
    }
}
