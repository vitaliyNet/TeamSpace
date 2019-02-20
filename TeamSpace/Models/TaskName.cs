using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamSpace.Models
{
    public class TaskName
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } //list of usual job

        public string Description { get; set; }
    }
}