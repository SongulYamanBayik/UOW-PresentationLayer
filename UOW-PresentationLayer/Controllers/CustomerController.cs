using Microsoft.AspNetCore.Mvc;
using OUW_DAL.Concrete;
using OUW_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOW_PresentationLayer.Models;

namespace UOW_PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult SendMoney()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMoney(ProcessViewModel p)
        {
            Context context = new Context();

            decimal senderCurrentBalance = context.Customers.Where(x => x.ID == p.SenderID).Select(y => y.Balance).FirstOrDefault();
            decimal receiverCurrentBalance = context.Customers.Where(x => x.ID == p.ReceiverID).Select(y => y.Balance).FirstOrDefault();
            p.SenderNewBalance = senderCurrentBalance - p.Amount;
            p.ReceiverNewBalance = receiverCurrentBalance + p.Amount;

            var value1 = new Customer()
            {
                ID = p.SenderID,
                Balance = p.SenderNewBalance
            };
            var value2 = new Customer()
            {
                ID = p.ReceiverID,
                Balance = p.ReceiverNewBalance
            };
            return View();
        }
    }
}
