﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NSE.Service;
using NSE.Service.Interfaces;
using NSE.Shared.Models;

namespace NSE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SQLInjectionController : ControllerBase
    {
        #region Fields

        /// <summary>
        /// The SQLInnjection Service
        /// </summary>
        public readonly ISQLInjectionService sqlInjectionService;

        #endregion

        #region Constructors

        /// <summary>
        /// The default constructor
        /// </summary>
        public SQLInjectionController()
        {
            sqlInjectionService = new SQLInjectionService();
        }

        #endregion

        #region Methods

        [HttpGet]
        public IEnumerable<User> Get()
        {
            sqlInjectionService.GetUsers("", "");
            return null;
        }

        #endregion

    }
}