using System.Collections;
using BugzillaDotNet.Entity.Bugs;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.Response
{
    class BugResponse
    {
        [JsonProperty("bugs")]
        public Bug[] Bugs { get; set; }

        [JsonProperty("faults")]
        public object[] Faults { get; set; }
    }
}
