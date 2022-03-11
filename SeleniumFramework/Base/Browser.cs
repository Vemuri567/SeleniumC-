using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Base
{
    public class Browser
    {
        private readonly DriverContext driverContext;

        public Browser(DriverContext driver)
        {
            driverContext = driver;
        }

        public BrowserType Type { get; set; }

    }

    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}
