using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using NSE.Repository.Interfaces;
using NSE.Shared.Models;
using System;

namespace NSE.Repository
{
    public class SQLInjectionRepository : BaseInjectionRepository, ISQLInjectionRepository
    {
        #region Methods

        /// <summary>
        /// Gets the users
        /// </summary>
        /// <param name="query">The query</param>
        /// <returns>A list of user</returns>
        public IEnumerable<User> GetUsers(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();

                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            return MapUser(dataReader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #endregion

    }
}
