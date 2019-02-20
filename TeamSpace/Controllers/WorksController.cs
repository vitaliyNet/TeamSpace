using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TeamSpace.Models;
using TeamSpace.ViewModel;

namespace TeamSpace.Controllers
{
    public class WorksController : Controller
    {
        // getting db context
        private readonly ApplicationDbContext _context;

        public WorksController()
        {
            _context = new ApplicationDbContext();
        }
        
        // create task form
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new WorkFormViewModel()
            {
                TaskNames = _context.TaskNames.ToList()
            };
            return View(viewModel);
        }
        
        [Authorize]
        [HttpPost]
        public ActionResult Create(WorkFormViewModel model)
        {
            var user = User.Identity.GetUserId();
            var teamLead = _context.Users.Single(u => u.Id == user);
            var taskName = _context.TaskNames.Single(t => t.Id == model.TaskName);
            var work = new Work()
            {
                TeamLead = teamLead,
                Location = model.Location,
                DateTime = DateTime.Parse(string.Format("{0} {1}", model.Date, model.Time)),
                TaskName = taskName
            };

            _context.Works.Add(work);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}