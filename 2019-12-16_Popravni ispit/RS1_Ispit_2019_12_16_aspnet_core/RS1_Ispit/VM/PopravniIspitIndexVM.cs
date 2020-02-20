﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.VM
{
    public class PopravniIspitIndexVM
    {
        public int SkolskaGodinaId { get; set; }
        public List<SelectListItem> SkolskeGodine { get; set; }
        public int SkolaId { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public int PredmetId { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
    }
}