using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.Bugs;

namespace BugzillaDotNet.Interface
{
    public interface IBugManager
    {
        Task<Bug> GetBug(int id);

        Task<Bug> GetBug(string alias);

        Task<Bug[]> GetBugs(int[] ids);

        Task<Bug[]> GetBugs(string[] aliasStrings);
    }
}
