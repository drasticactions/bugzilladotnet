using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.User
{
    public class UserResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
