﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.BLL.DTO.ModelsDTO
{
    public class DictionaryUKTVDTO
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string CodeUKTV { get; set; }
        public string DescriptionUA { get; set; }
        public int? Level { get; set; }
    }
    
}
