using System;
using System.Collections.Generic;
using NSE.Repository;
using NSE.Repository.Interfaces;
using NSE.Service.Interfaces;
using NSE.Shared.Models;

namespace NSE.Service
{
    public class SQLInjectionService : ISQLInjectionService
    {
        #region Fields

        /// <summary>
        /// The SQl Injection repository
        /// </summary>
        private readonly ISQLInjectionRepository sqlInjectionRepository;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public SQLInjectionService()
        {
            sqlInjectionRepository = new SQLInjectionRepository();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the user
        /// </summary>
        /// <param name="user">The user</param>
        /// <returns></returns>
        public IEnumerable<User> GetUsers(User user)
        {
            string userName = user.UserName;
            string password = user.Password;

            string query = "SELECT * FROM [NSEDataBase].[dbo].[login] WHERE [userName] = '" + userName + "' AND [password] = '" + password + "'";

            IEnumerable<User> users = sqlInjectionRepository.GetUsers(query);

            return users;

        }
        #endregion

    }
}
