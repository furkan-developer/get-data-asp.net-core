using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BtkCamp.Models;

namespace BtkCamp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICollection<Candidate> _candidates;

        public CourseController(ICollection<Candidate> candidates)
        {
            this._candidates = candidates;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Candidate candidate)
        {
            _candidates.Add(candidate);
            return View(viewName: "ApplyFeedBack", model: candidate);
        }
    }
}