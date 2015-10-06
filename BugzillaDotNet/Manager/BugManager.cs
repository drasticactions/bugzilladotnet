using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Common;
using BugzillaDotNet.Entity.Bugs;
using BugzillaDotNet.Entity.Response;
using BugzillaDotNet.Interface;
using Newtonsoft.Json;

namespace BugzillaDotNet.Manager
{
    public class BugManager : IBugManager
    {
        private readonly IWebManager _webManager;
        public BugManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public BugManager(string baseUrl, string authenticationToken)
            : this(new WebManager(baseUrl, authenticationToken))
        {
        }

        public async Task<Bug> GetBug(int id)
        {
            var url = string.Format(EndPoints.Bug, id);
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugResponse>(result.ResultJson);
            return response.Bugs.FirstOrDefault();
        }

        public async Task<Bug> GetBug(string alias)
        {
            var url = string.Format(EndPoints.Bug, alias);
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugResponse>(result.ResultJson);
            return response.Bugs.FirstOrDefault();
        }
    }
}
