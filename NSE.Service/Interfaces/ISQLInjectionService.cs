using System.Collections.Generic;
using NSE.Shared.Models;

namespace NSE.Service.Interfaces
{
    public interface ISQLInjectionService
    {
        /// <summary>
        /// Gets the user
        /// </summary>
        /// <param name="user">Get the user</param>
        /// <returns>List of user</returns>
        IEnumerable<User> GetUsers(User user);
    }
}
