using System;
using System.Collections.Generic;
using NSE.Repository;
using NSE.Repository.Interfaces;
using NSE.Service.Interfaces;
using NSE.Shared.Models;

namespace NSE.Service
{
    public class NoSQLInjectionService : INoSQLInjectionService
    {
        #region Fields

        /// <summary>
        /// The No SQl Injection repository
        /// </summary>
        private readonly INoSQLInjectionRepository noSQLInjectionRepository;

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public NoSQLInjectionService()
        {
            noSQLInjectionRepository = new NoSQLInjectionRepository();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the users
        /// </summary>
        /// <param name="user">The user</param>
        /// <returns></returns>
        public IEnumerable<User> GetUsers(User user)
        {
            IEnumerable<User> users = noSQLInjectionRepository.GetUsers(user.UserName, user.Password);
            return users;
        }

        #endregion

    }
}
