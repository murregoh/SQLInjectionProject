using System;
using System.Collections.Generic;
using NSE.Repository.Interfaces;
using NSE.Shared.Models;

namespace NSE.Repository
{
    public class SQLInjectionRepository : BaseInjectionRepository, ISQLInjectionRepository
    {

        public IEnumerable<User> GetUsers(string query)
        {
            throw new NotImplementedException();
        }
    }
}
