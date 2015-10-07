using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugzillaDotNet.Entity.User;

namespace BugzillaDotNet.Interface
{
    public interface IUserManager
    {
        Task<UserResponse> Login(string login, string password, bool restrictLogin = false);

        Task<bool> Logout(string token);

        Task<bool> ValidLogin(string login, string token);

        Task<int> CreateUser(NewUser user);
    }
}
