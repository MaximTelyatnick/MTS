﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MTS.DAL.Entities.Models
{
    public class MTS_DETAILS
    {
        [Key]
        public int ID { get; set; }
        public int SPECIFICATIONS_ID { get; set; }
        public int? CREATED_DETAILS_ID { get; set; }
        public decimal QUANTITY_OF_BLANKS { get; set; }
        public int? CODZAK { get; set; }
        public decimal QUANTITY { get; set; }
        public int? CHANGES { get; set; }
        public DateTime? TIME_OF_ADD { get; set; }
    }
}
