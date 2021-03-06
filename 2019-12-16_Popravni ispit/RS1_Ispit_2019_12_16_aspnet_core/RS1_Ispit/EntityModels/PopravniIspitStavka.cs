﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class PopravniIspitStavka
    {
        public int Id { get; set; }
        [ForeignKey(nameof(PopravniIspitId))]
        public PopravniIspit PopravniIspit { get; set; }
        public int PopravniIspitId { get; set; }
        [ForeignKey(nameof(OdjeljenjeStavkaId))]
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaId { get; set; }
        public bool IsPrisutan { get; set; }
        public float? BrojBodova { get; set; }
        public bool ImaPravo { get; set; } = true;

    }
}
