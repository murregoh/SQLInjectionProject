using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NSE.Shared.Models;

namespace NSE.Repository
{
    public class BaseInjectionRepository
    {

        #region Constants

        /// <summary>
        /// The connection string
        /// </summary>
        protected const string CONNECTION_STRING = "Server=localhost;Database=NSEDataBase;User Id = sa; Password=MyPassw0rd";

        #endregion

        #region Constructors

        public BaseInjectionRepository()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Maps the user with the data from NSEDatabase
        /// </summary>
        /// <param name="dataReader">The data reader</param>
        /// <returns>A list of users</returns>
        protected List<User> MapUser(SqlDataReader dataReader)
        {
            int idColumn = dataReader.GetOrdinal("Id");
            int userNameColumn = dataReader.GetOrdinal("userName");
            int passwordColumn = dataReader.GetOrdinal("password");

            List<User> users = new List<User>();

            while (dataReader.Read())
            {
                User user = new User
                {
                    Id = dataReader.GetInt32(idColumn),
                    UserName = dataReader.GetString(userNameColumn),
                    Password = dataReader.GetString(passwordColumn)
                };

                users.Add(user);

            }

            return users;
        }

        #endregion


    }
}
