using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaDotNet.Common
{
    public static class EndPoints
    {
        public static string Bug = "/rest/bug/{0}";

        public static string BugsIds = "/rest/bug?id={0}";

        public static string BugsAlias = "/rest/bug?alias={0}";
    }
}
