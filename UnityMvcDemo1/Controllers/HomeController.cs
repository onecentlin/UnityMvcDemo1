using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityMvcDemo1.Services;

namespace UnityMvcDemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDemoService _demoService;

        public HomeController(IDemoService demoService)
        {
            this._demoService = demoService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            ViewBag.Greetings = _demoService.Greetings(name);

            return View();
        }
    }
}