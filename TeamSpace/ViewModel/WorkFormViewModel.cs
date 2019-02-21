using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TeamSpace.Models;

namespace TeamSpace.ViewModel
{
    public class WorkFormViewModel
    {
        [Required]
        public string Location { get; set; }

        [Required]
        [ProperDate]
        public string Date { get; set; }

        [Required]
        [ProperTime]
        public string Time { get; set; }

        [Required]
        public int TaskName { get; set; }

        public IEnumerable<TaskName> TaskNames { get; set; }

        public DateTime GetDateTime() //convert to function to avoid null reference exception
        {
             return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }

      
    }
}