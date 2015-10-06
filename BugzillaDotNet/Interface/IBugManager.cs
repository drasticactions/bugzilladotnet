using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.Bugs;
using BugzillaDotNet.Entity.Response;

namespace BugzillaDotNet.Interface
{
    public interface IBugManager
    {
        Task<Bug> GetBug(int id);

        Task<Bug> GetBug(string alias);

        Task<Bug[]> GetBugs(int[] ids);

        Task<Bug[]> GetBugs(string[] aliasStrings);

        Task<Entity.BugHistory.Bug> GetBugHistory(int id);

        Task<Entity.BugHistory.Bug> GetBugHistory(int id, DateTime newSince);

        Task<Entity.BugHistory.Bug> GetBugHistory(string alias);

        Task<Entity.BugHistory.Bug> GetBugHistory(string alias, DateTime newSince);
    }
}
