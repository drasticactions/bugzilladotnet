using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.User
{
    public class NewUser
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("full_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Password { get; set; }
    }
}
