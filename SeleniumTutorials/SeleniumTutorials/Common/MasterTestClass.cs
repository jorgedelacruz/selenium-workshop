using System;

namespace SeleniumTutorials.Common
{
    public class MasterTestClass : IDisposable
    {
        public MasterTestClass()
        {
            //do stuff
        }

        public void Dispose()
        {
            MyDriver.Driver.Quit();
        }
    }
}
