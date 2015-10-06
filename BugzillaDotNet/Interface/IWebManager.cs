using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.Web;

namespace BugzillaDotNet.Interface
{
    public interface IWebManager
    {
        Task<Result> GetData(string uri);

        Task<Result> PutData(string uri, StringContent json);

        Task<Result> DeleteData(string uri, StringContent json);

        Task<Result> PostData(string uri, StringContent content);

        Task<Result> PostData(string uri, FormUrlEncodedContent header);

        Task<Result> PostData(string uri, MultipartContent content);
    }
}
