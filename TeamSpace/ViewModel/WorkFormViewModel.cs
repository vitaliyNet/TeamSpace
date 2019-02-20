using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamSpace.Models;

namespace TeamSpace.ViewModel
{
    public class WorkFormViewModel
    {
        public string Location { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int TaskName { get; set; }
        public IEnumerable<TaskName> TaskNames { get; set; }
    }
}