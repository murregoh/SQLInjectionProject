using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NSE.Service;
using NSE.Service.Interfaces;
using NSE.Shared.Models;

namespace NSE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoSQLInjectionController : ControllerBase
    {
        #region Fields

        /// <summary>
        /// The NoSQLInnjection Service
        /// </summary>
        private readonly INoSQLInjectionService noSqlInjectionService;

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public NoSQLInjectionController()
        {
            noSqlInjectionService = new NoSQLInjectionService();
        }

        #endregion

        #region Methods

        [HttpGet]
        public IEnumerable<User> Get([FromBody] User user)
        {
            IEnumerable<User> users = noSqlInjectionService.GetUsers(user);

            return users;
        }

        #endregion

    }
}
