﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
    public class MTS_MATERIALS
    {
        [Key]
        public int ID { get; set; }
        public int? NOMENCLATURES_ID { get; set; }
        public decimal? QUANTITY { get; set; }
        public int? SPECIFICATIONS_ID { get; set; }
        public int? CODZAK { get; set; }
        public int? CHANGES { get; set; }
        public DateTime? TIME_OF_ADD { get; set; }
    }
}
