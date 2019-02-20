﻿using System;
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
                TaskNames = _context.TaskNames.ToList()  // avoid null reference exception cause taskNames not populated
            };
            return View(viewModel);
        }
        
        [Authorize]
        [HttpPost]
        public ActionResult Create(WorkFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.TaskNames = _context.TaskNames.ToList(); // avoid null reference exception cause taskNames not populated
                return View("Create", model);
            }

            var work = new Work()
            {
                TeamLeadId = User.Identity.GetUserId(),
                Location = model.Location,
                DateTime = model.GetDateTime(),
                TaskNameId = model.TaskName
            };

            _context.Works.Add(work);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}