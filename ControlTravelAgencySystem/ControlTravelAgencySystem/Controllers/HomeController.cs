﻿using ControlTravelAgencySystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ControlTravelAgencySystem.Controllers
{
    /// <summary>
    /// Контроллер домашней страницы
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// GET: /
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
    }
}
