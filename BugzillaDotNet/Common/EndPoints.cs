using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaDotNet.Common
{
    public static class EndPoints
    {
        public static string Bug = "/bug/{0}";

        public static string BugHistory = "/bug/{0}/history";

        public static string BugHistorySince = "/bug/{0}/history?new_since={1}";

        public static string BugsIds = "/bug?id={0}";

        public static string BugsAlias = "/bug?alias={0}";

        public static string BugSearch = "/bug?{0}";

        public static string CreateBug = "/bug";

        public static string Login = "/login?login={0}&password={1}";

        public static string Logout = "/logout?token={0}";

        public static string ValidLogin = "/valid_login?login={0}&token={1}";

        public static string User = "/user";
    }
}
