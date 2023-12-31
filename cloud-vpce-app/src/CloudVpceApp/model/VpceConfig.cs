﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVpceApp.model
{
    public class VpceConfig
    {
        public VpceConfig()
        {
        }

        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("serviceName")] public string ServiceName { get; set; }
        [JsonProperty("openPorts")] public List<int> OpenPorts { get; set; }
        
    }
}
