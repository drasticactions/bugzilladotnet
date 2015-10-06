using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.BugHistory;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.Response
{
    class BugHistoryResponse
    {
        [JsonProperty("bugs")]
        public Bug[] BugsHistory { get; set; }
    }
}
