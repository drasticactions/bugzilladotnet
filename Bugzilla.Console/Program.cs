using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Manager;

namespace Bugzilla.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var webManager = new WebManager("https://landfill.bugzilla.org/bugzilla-5.0-branch");
            var bugManager = new BugManager(webManager);
            var firstBug = await bugManager.GetBug(1);
            var firstBugAlias = await bugManager.GetBug("Main");
        }
    }
}
