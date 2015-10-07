using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BugzillaDotNet.Entity.Bugs
{
    public class NewBug
    {
        [JsonProperty("alias", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Alias { get; set; }

        [JsonProperty("assigned_to", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AssignedTo { get; set; }

        [JsonProperty("cc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Cc { get; set; }

        [JsonProperty("comment_is_private", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CommentIsPrivate { get; set; }

        [JsonProperty("comment_tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] CommentTags { get; set; }

        [JsonProperty("flags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NewFlag[] Flags { get; set; }

        [JsonProperty("is_markdown", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsMarkdown { get; set; }

        [JsonProperty("op_sys", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OpSys { get; set; }

        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Platform { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("qa_contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string QaContact { get; set; }

        [JsonProperty("resolution", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Resolution { get; set; }

        [JsonProperty("groups", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string[] Groups { get; set; }

        [JsonProperty("severity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Severity { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("target_milestone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TargetMilestone { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
