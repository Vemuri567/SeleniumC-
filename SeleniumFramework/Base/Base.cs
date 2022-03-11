using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Base
{
    public class Base
    {
        public readonly DriverConfig _driverConfig;

        public Base(DriverConfig driverConfig)
        {
            _driverConfig = driverConfig;
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            return (TPage)Activator.CreateInstance(typeof(TPage));
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
