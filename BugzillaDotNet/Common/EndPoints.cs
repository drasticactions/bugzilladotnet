﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaDotNet.Common
{
    public static class EndPoints
    {
        public static string Bug = "/rest/bug/{0}";

        public static string BugHistory = "/rest/bug/{0}/history";

        public static string BugHistorySince = "/rest/bug/{0}/history?new_since={1}";

        public static string BugsIds = "/rest/bug?id={0}";

        public static string BugsAlias = "/rest/bug?alias={0}";

        public static string BugSearch = "/rest/bug?{0}";

        public static string CreateBug = "/rest/bug";

        public static string Login = "/rest/login?login={0}&password={1}";

        public static string Logout = "/rest/logout?token={0}";

        public static string ValidLogin = "/rest/valid_login?login={0}&token={1}";

        public static string User = "/rest/user";
    }
}
