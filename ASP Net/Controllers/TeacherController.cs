using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicMakerProgram.Data;
using MusicMakerProgram.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicMakerProgram.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDBContext _db;
        int? identifier;

        public TeacherController(ApplicationDBContext db)
        {
            _db = db;
        }

        //--------------LOGIN-------------------
        // GET - Create
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // POST - create
        public IActionResult Login(Teacher t)
        {

            Teacher userDetails = _db.Teachers.Where(
                x => x.Name == t.Name
            ).SingleOrDefault();

            if (userDetails == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("DisplayClasses", userDetails);
        }

        //------------REGISTER------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult Create(Teacher t)
        {
            _db.Teachers.Add(t);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Failed()
        {
            return View();
        }

        //--------Class VIEW -------------
        [HttpGet]
        public IActionResult DisplayClasses(Teacher t)
        {
            IEnumerable<Class> classList = _db.Classes.Where(
                x => x.TID == t.TID
                );

            return View(classList);
        }

        //--------Class List View------
        public IActionResult DisplayStudents(int? id)
        {
            var obj = _db.Classes.Find(id);
            IEnumerable<Performer> studentList = _db.Performers.Where(
                x=> x.ClassID == obj.ClassID
                );

            return View(studentList);
        }

        //-------AssignPiece View-------
        public IActionResult AssignPiece(int? id)
        {
            identifier = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult AssignPiece(Knows k)
        {
            k.PerformerID = (int)identifier;
            _db.KnowsS.Add(k);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
