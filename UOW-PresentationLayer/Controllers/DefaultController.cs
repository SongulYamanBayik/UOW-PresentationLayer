using Microsoft.AspNetCore.Mvc;
using OUW_DAL.Concrete;
using OUW_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UOW_PresentationLayer.Controllers
{

    public class DefaultController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            context.Update(new Customer
            {
                ID = 1,
                Name = "Songül",
                Surname = "Yaman Bayık",
                Mail="songul@gmail.com",
                Balance=15000
            });
            context.SaveChanges();

            context.Update(new Customer
            {
                ID = 2,
                Name="Hayri",
                Surname="Bayık",
                Mail="hayri@gmail.com",
                Balance=20000
            });
            context.SaveChanges();
            return View();
        }
    }
}
