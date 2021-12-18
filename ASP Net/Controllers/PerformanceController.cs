using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicMakerProgram.Data;
using MusicMakerProgram.Models;

namespace MusicMakerProgram.Controllers
{
    public class PerformanceController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PerformanceController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Performance> performanceList = _db.Performances;
            return View(performanceList);
        }

        // GET - create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult Create(Performance perf)
        {
            _db.Performances.Add(perf);
            _db.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
