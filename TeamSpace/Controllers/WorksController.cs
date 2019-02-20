using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamSpace.Models;
using TeamSpace.ViewModel;

namespace TeamSpace.Controllers
{
    public class WorksController : Controller
    {
        // GET: Works
        private readonly ApplicationDbContext _context;

        public WorksController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Works
        public ActionResult Create()
        {
            var viewModel = new WorkFormViewModel()
            {
                TaskNames = _context.TaskNames.ToList()
            };
            return View(viewModel);
        }
    }
}