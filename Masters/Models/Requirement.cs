﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Masters.Models
{
    public class Requirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Requirement Id")]
        public int RequirementId { get; set; }

        [Required]
        [Display(Name = "Abbreviation")]
        public string RequirementAbbrev { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string RequirementName { get; set; }
        public bool done { get; set; }


    }
}
