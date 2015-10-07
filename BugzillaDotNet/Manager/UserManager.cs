using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Common;
using BugzillaDotNet.Entity.Bugs;
using BugzillaDotNet.Entity.Response;
using BugzillaDotNet.Entity.User;
using BugzillaDotNet.Interface;
using Newtonsoft.Json;

namespace BugzillaDotNet.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IWebManager _webManager;
        public UserManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public UserManager(string baseUrl, string authenticationToken)
            : this(new WebManager(baseUrl, authenticationToken))
        {
        }

        public async Task<UserResponse> Login(string login, string password, bool restrictLogin = false)
        {
            var url = string.Format(EndPoints.Login, login, password);
            if (restrictLogin)
            {
                url += "&restrict_login=true";
            }
            var result = await _webManager.GetData(url);
            var response = JsonConvert.DeserializeObject<UserResponse>(result.ResultJson);
            return response;
        }

        public async Task<bool> Logout(string token)
        {
            var url = string.Format(EndPoints.Logout, token);
            var result = await _webManager.GetData(url);
            return result.IsSuccess;
        }

        public async Task<bool> ValidLogin(string login, string token)
        {
            var url = string.Format(EndPoints.ValidLogin, login, token);
            var result = await _webManager.GetData(url);
            return result.IsSuccess;
        }

        public async Task<int> CreateUser(NewUser user)
        {
            var result = await _webManager.PostData(EndPoints.User, new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
            var response = JsonConvert.DeserializeObject<UserResponse>(result.ResultJson);
            return response.Id;
        }
    }
}
