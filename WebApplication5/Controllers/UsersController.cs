using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(List<string> qoo)
        {
            @ViewBag.Selected = qoo.Where(x => x != "false").ToList();
            return View();
            
        }

    }
}