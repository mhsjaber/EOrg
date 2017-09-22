using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EOrg.Core;
using EOrg.Core.Membership;

namespace EOrg.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICoreUnitOfWork coreUnitOfWork;
        public HomeController(ICoreUnitOfWork coreUnitOfWork)
        {
            this.coreUnitOfWork = coreUnitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}