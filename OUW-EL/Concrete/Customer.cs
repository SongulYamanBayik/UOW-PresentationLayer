using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_EL.Concrete
{
   public class Customer
    {


        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public decimal Balance { get; set; }


        public BankAccountDetail BankAccountDetail { get; set; }
    }
}
