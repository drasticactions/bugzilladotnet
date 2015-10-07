using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.Bugs
{
    public class NewFlag
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("type_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TypeId { get; set; }

        [JsonProperty("requestee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Requestee { get; set; }
    }
}
