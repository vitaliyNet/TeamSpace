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

        [Required]
        public ApplicationUser TeamLead { get; set; }

        public DateTime DateTime { get; set; } //when its gonna happend

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [Required]
        public TaskName TaskName { get; set; }
    }
}