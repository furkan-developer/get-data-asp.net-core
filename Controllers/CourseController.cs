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
            return View(model:_candidates);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Apply(Candidate candidate)
        {
            if(ModelState.IsValid)
            {
                _candidates.Add(candidate);
                TempData["InsertStatus"] = "Ekleme işlemi başarılıdır.";

                return RedirectToAction("Index");
            }
            
            return View(candidate);
        }
    }
}