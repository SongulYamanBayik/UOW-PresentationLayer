﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUW_EL.Concrete
{
   public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }


        public List<Sponsor> Sponsors { get; set; }

    }
}
