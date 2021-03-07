using System.Collections.Generic;
using NSE.Shared.Models;

namespace NSE.Service.Interfaces
{
    public interface INoSQLInjectionService
    {
        /// <summary>
        /// Get the user
        /// </summary>
        /// <param name="user">The user</param>
        /// <returns>A user</returns>
        IEnumerable<User> GetUsers(User user);
    }
}
