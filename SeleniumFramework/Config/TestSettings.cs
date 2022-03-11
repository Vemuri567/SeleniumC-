using Newtonsoft.Json;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Config
{
    [JsonObject("testSettings")]
    public class TestSettings
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }


        [JsonProperty("browser")]
        public BrowserType Browser { get; set; }


        

    }
}
