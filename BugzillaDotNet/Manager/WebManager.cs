using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.Web;
using BugzillaDotNet.Exception;
using BugzillaDotNet.Interface;

namespace BugzillaDotNet.Manager
{
    public class WebManager : IWebManager
    {
        public WebManager(string baseUrl, string authToken = null)
        {
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new ManagerException("You must set a base url endpoint.");
            }
            BaseUrl = baseUrl;
            ApiKey = authToken;
        }

        public string BaseUrl { get; set; }

        public string ApiKey { get; set; }

        public async Task<Result> GetData(string uri)
        {
            if (ApiKey != null)
            {
                // TODO: Set Token for logged in behavior
            }
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(BaseUrl + uri);
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new WebException("Bugzilla API Error: Service not found.");
                    }
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return string.IsNullOrEmpty(responseContent) ? new Result(response.IsSuccessStatusCode, string.Empty) : new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (System.Exception ex)
                {
                    throw new WebException("Bugzilla API Error: Service error", ex);
                }
            }
        }

        public Task<Result> PutData(string uri, StringContent json)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteData(string uri, StringContent json)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> PostData(string uri, StringContent content)
        {
            if (ApiKey != null)
            {
                // TODO: Set Token for logged in behavior
            }
            using (var httpClient = new HttpClient())
            {
                try
                {
                    if (content == null) content = new StringContent(string.Empty);
                    var response = await httpClient.PostAsync(BaseUrl + uri, content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (System.Exception ex)
                {
                    throw new WebException("Bugzilla API Error: Service error", ex);
                }
            }
        }

        public async Task<Result> PostData(string uri, FormUrlEncodedContent header)
        {
            if (ApiKey != null)
            {
                // TODO: Set Token for logged in behavior
            }
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsync(BaseUrl + uri, header);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (System.Exception ex)
                {
                    throw new WebException("Bugzilla API Error: Service error", ex);
                }
            }
        }

        public Task<Result> PostData(string uri, MultipartContent content)
        {
            throw new NotImplementedException();
        }
    }
}
