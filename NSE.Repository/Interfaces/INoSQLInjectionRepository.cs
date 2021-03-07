using System.Collections.Generic;
using NSE.Shared.Models;

namespace NSE.Repository.Interfaces
{
    public interface INoSQLInjectionRepository
    {
        /// <summary>
        /// Returns a user
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The password</param>
        /// <returns>A user</returns>
        IEnumerable<User> GetUsers(string userName, string password);
    }
}