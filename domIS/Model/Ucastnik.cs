﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ucastnik
    {
        public int UcastnikId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public Pohlavi Pohlavi { get; set; }
        public DateTime Narozen { get; set; }

        public Ucastnik()
        {
            UcastnikId = -1;
        }
    }
}
