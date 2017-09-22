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
            var ss = new Customer()
            {
                CreatedOn = DateTime.Now,
                DateOfBirth = DateTime.Now,
                FamilyMembers =1,
                FatherName = "Nijam Uddin",
                FullName = "Jaber Kibria",
                MonthlyExpenditure = 10000,
                MonthlyIncome = 15000,
                MotherName = "Sharifun Nahar",
                NIDNumber = "19970003231232",
                Occupation = "Software Engineer",
                PermanentAddress = new Address()
                {
                    District = "Satkhira",
                    Thana = "Debhata",
                    PostOffice = "Gurugram",
                    Village = "Bohera"
                },
                PresentAddress = new Address()
                {
                    District = "Satkhira",
                    Thana = "Debhata",
                    PostOffice = "Gurugram",
                    Village = "Bohera"
                },
                UpdatedOn = DateTime.Now
            };
            coreUnitOfWork.CustomerRepository.Insert(ss);
            coreUnitOfWork.Save();
            var ff = coreUnitOfWork.CustomerRepository.Get();
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