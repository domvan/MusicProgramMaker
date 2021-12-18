using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicMakerProgram.Data;
using MusicMakerProgram.Models;
using System.Dynamic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicMakerProgram.Controllers
{
    public class GuestController : Controller
    {
        private readonly ApplicationDBContext _db;

        public GuestController(ApplicationDBContext db)
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
        public IActionResult Login(Guest g)
        {

            Guest userDetails = _db.Guests.Where(
                x=> x.Username == g.Username && x.Password == g.Password
            ).SingleOrDefault();
           
            if (userDetails == null)
            {
                
               return RedirectToAction("Create");
            }
            return RedirectToAction("DisplayPrograms", userDetails);
        }

        //------------REGISTER------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult Create(Guest g)
        {
            _db.Guests.Add(g);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Failed()
        {
            return View();
        }


        //----------DISPLAY PROGRAMS----------
        [HttpGet]
        public IActionResult DisplayPrograms(Guest guest)
        {
            List<MusicProgram> programList = new List<MusicProgram>();
            var CV = _db.CanViews.Where(
                a => a.GuestID == guest.GuestID);
            foreach (var c in CV)
            {
                programList.Add(_db.Programs.Find(c.PId));
            }

            return View(programList);
        }

        //-----DISPLAY PERFORMANCES---------
        public IActionResult DisplayPerformances(int? id)
        {
            List<Performance> performanceList = new List<Performance>();
            IEnumerable<Performance> obj = _db.Performances.Where(
                x => x.PID == id
                );
            if (obj!= null) {
                return View(obj);
            }

            return RedirectToAction("Index");
            
        }

        public IActionResult DisplayPiece(int? id)
        {
            var piece = _db.Pieces.Find(id);
            return View(piece);
        }

       

    }
}
