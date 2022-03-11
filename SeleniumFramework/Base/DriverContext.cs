using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Base
{
    public class DriverContext
    {
        public readonly DriverConfig _driverConfig;

        public DriverContext(DriverConfig driverConfig)
        {
            _driverConfig = driverConfig;
        }


        public void GoToUrl(string url)
        {
            _driverConfig.Driver.Url = url;
        }


        public static Browser Browser { get; set; }

    }
}
}
