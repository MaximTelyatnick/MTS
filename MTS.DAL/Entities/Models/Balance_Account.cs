﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.DAL.Entities.Models
{
    public class Balance_Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public int? AccountId { get; set; }
        //public int? VatId { get; set; }
    }
}
