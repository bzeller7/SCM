using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCM.Models;

namespace SCM.Controllers
{
    public class ContactController : Controller
    {
        private readonly InfoContext context;

        public ContactController(InfoContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact c)
        {
            if (ModelState.IsValid)
            {
                ContactDB.AddContact(c, context);
                ViewData["Message"] = $"{c.Name} was added!";
                return RedirectToAction("Create");
            }
            return View();
        }

    }
}