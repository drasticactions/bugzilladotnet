﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.BugHistory
{

    public class Change
    {

        [JsonProperty("added")]
        public string Added { get; set; }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("removed")]
        public string Removed { get; set; }
    }

}
