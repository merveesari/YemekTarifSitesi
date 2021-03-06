﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekTarifSitesi.Models
{
    public class YemekTarifModel
    {
        public IEnumerable<Yemek> Yemek { get; set; }
        public IEnumerable<Malzeme> Malzeme { get; set; }
        public IEnumerable<YemekTur> YemekTur { get; set; }
        public IEnumerable<YemekMalzeme> YemekMalzeme { get; set; }

    }
}
