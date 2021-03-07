using System.Collections.Generic;
using NSE.Shared.Models;

namespace NSE.Service.Interfaces
{
    public interface ISQLInjectionService
    {
        /// <summary>
        /// To Get the user
        /// </summary>
        /// <param name="userName">The User name</param>
        /// <param name="password">The password</param>
        /// <returns>A list of users</returns>
        IEnumerable<User> GetUsers(string userName, string password);
    }
}
