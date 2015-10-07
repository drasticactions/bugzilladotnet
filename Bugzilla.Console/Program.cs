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
            var searchBug =
                await
                    bugManager.SearchBugs(
                        "bug_status=VERIFIED&classification=Mercury&order=Importance&product=WorldControl");
            //var firstBug = await bugManager.GetBug(1);
            //var firstBugAlias = await bugManager.GetBug("Main");
            //var bugList = await bugManager.GetBugs(new [] {1, 2});
            //var bugListString = await bugManager.GetBugs(new[] { "Main", "en" });

            //var firstBugHistory = await bugManager.GetBugHistory(1);
            //var firstBugHistoryAlias = await bugManager.GetBugHistory("Main");

            //var firstBugHistorySince = await bugManager.GetBugHistory(1, new DateTime(2003, 04, 01));
            //var firstBugHistoryAliasSince = await bugManager.GetBugHistory("Main", new DateTime(2003, 04, 01));
        }
    }
}
