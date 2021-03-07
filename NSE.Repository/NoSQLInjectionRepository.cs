using System.Collections.Generic;
using System.Data.SqlClient;
using NSE.Repository.Interfaces;
using NSE.Shared.Models;
using System.Data;
using System;

namespace NSE.Repository
{
    public class NoSQLInjectionRepository : BaseInjectionRepository, INoSQLInjectionRepository
    {
     
        #region Public Methods

        /// <summary>
        /// Get the users
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IEnumerable<User> GetUsers(string userName, string password)
        {
            try
            {
                // Creating the parameters
                List<SqlParameter> parameters = new List<SqlParameter>();

                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@userName",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = userName
                };
                parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@password",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = password
                };
                parameters.Add(parameter);

                // Creating, executing and reading the SP
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand command = new SqlCommand("usp_getUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters.ToArray());
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