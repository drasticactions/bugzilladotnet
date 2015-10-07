using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Common;
using BugzillaDotNet.Entity.Bugs;
using BugzillaDotNet.Entity.Response;
using BugzillaDotNet.Interface;
using Microsoft.VisualBasic;
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

        public async Task<Bug[]> GetBugs(int[] ids)
        {
            var url = string.Format(EndPoints.BugsIds, string.Join(",", ids));
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugResponse>(result.ResultJson);
            return response.Bugs;
        }

        public async Task<Bug[]> GetBugs(string[] aliasStrings)
        {
            var url = string.Format(EndPoints.BugsAlias, string.Join(",", aliasStrings));
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugResponse>(result.ResultJson);
            return response.Bugs;
        }

        public async Task<Entity.BugHistory.Bug> GetBugHistory(int id)
        {
            var url = string.Format(EndPoints.BugHistory, id);
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugHistoryResponse>(result.ResultJson);
            return response.BugsHistory.FirstOrDefault();
        }

        public async Task<Entity.BugHistory.Bug> GetBugHistory(int id, DateTime newSince)
        {
            var url = string.Format(EndPoints.BugHistorySince, id, newSince.ToString("yyyy-MM-dd"));
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugHistoryResponse>(result.ResultJson);
            return response.BugsHistory.FirstOrDefault();
        }

        public async Task<Entity.BugHistory.Bug> GetBugHistory(string alias)
        {
            var url = string.Format(EndPoints.BugHistory, alias);
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugHistoryResponse>(result.ResultJson);
            return response.BugsHistory.FirstOrDefault();
        }

        public async Task<Entity.BugHistory.Bug> GetBugHistory(string alias, DateTime newSince)
        {
            var url = string.Format(EndPoints.BugHistorySince, alias, newSince.ToString("yyyy-MM-dd"));
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugHistoryResponse>(result.ResultJson);
            return response.BugsHistory.FirstOrDefault();
        }

        public async Task<Bug[]> SearchBugs(string query)
        {
            var url = string.Format(EndPoints.BugSearch, query);
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<BugResponse>(result.ResultJson);
            return response.Bugs;
        }

        public async Task<int> CreateBug(NewBug newBug)
        {
            var result = await _webManager.PostData(EndPoints.CreateBug, new StringContent(JsonConvert.SerializeObject(newBug), Encoding.UTF8, "application/json"));
            var response = JsonConvert.DeserializeObject<NewBugResponse>(result.ResultJson);
            return response.Id;
        }
    }
}
