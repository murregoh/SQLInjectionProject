using System;
using System.Collections.Generic;
using NSE.Service.Interfaces;
using NSE.Shared.Models;

namespace NSE.Service
{
    public class SQLInjectionService : ISQLInjectionService
    {
        public SQLInjectionService()
        {
        }

        public IEnumerable<User> GetUsers(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
