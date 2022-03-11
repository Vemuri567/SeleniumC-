using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumFramework.Config;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumFramework.Base
{
    public class TestInitializeHooks:Steps
    {
        private readonly DriverConfig _driverConfig;

        public TestInitializeHooks(DriverConfig driverConfig)
        {
            _driverConfig = driverConfig;
        }

        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Open Browser
            OpenBrowser(GetBrowserOption(Settings.BrowserType));

           

        }

        private void OpenBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            _driverConfig.Driver = new ChromeDriver(options);
        }

        
    }
}
