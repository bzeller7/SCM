﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCM.Controllers
{
    public class Blimpi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}