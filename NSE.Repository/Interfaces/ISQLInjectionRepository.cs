using System.Collections.Generic;
using NSE.Shared.Models;

namespace NSE.Repository.Interfaces
{
    public interface ISQLInjectionRepository
    {
        /// <summary>
        /// Returns a list of users
        /// </summary>
        /// <param name="query">The query to return users</param>
        /// <returns>A list of users</returns>
        IEnumerable<User> GetUsers(string query);
    }
}