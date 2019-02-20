using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamSpace.Models
{
    public class Work
    {
        public int Id { get; set; }

        public ApplicationUser TeamLead { get; set; }

        [Required]
        public string TeamLeadId { get; set; }

        public DateTime DateTime { get; set; } //when its gonna happend

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public TaskName TaskName { get; set; }

        [Required]
        public int TaskNameId { get; set; }
    }
}