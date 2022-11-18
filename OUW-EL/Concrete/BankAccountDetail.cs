using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_EL.Concrete
{
   public class BankAccountDetail
    {
        [Key,ForeignKey("Customer")]
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string AccountNumber { get; set; }


        public Customer Customer { get; set; }
    }
}
