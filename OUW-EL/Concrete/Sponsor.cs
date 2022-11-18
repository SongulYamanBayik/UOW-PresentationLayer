using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_EL.Concrete
{
   public class Sponsor
    {
        public int ID { get; set; }
        public string SponsorName { get; set; }


        public List<Team> Teams { get; set; }
    }
}
