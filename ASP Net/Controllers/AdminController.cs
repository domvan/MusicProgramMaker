using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicMakerProgram.Models;
using MusicMakerProgram.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicMakerProgram.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _db;
        private Admin ad;

        public AdminController(ApplicationDBContext db)
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
        public IActionResult Login(Admin a)
        {

            Admin userDetails = _db.Admins.Where(
                x => x.Username == a.Username && x.Password == a.Password
            ).SingleOrDefault();

            if (userDetails == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("AdminHome", userDetails);
        }

        //------------REGISTER------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult Create(Admin a)
        {
            _db.Admins.Add(a);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Failed()
        {
            return View();
        }

        //----------Admin Home------------
        public IActionResult AdminHome(Admin a)
        {
            ad = a;
            return View(a);
        }

        //-----Manage Classes---------
        public IActionResult ManageClasses(int? id)
        {
            Admin ad = _db.Admins.Find(id);
            List<Class> classList = new List<Class>();
            var mngs = _db.ManagesS.Where(
                x=> x.AdminID == ad.AdminID
                );
            foreach (var m in mngs)
            {
                classList.Add(_db.Classes.Find(m.ClassID));
            }
            return View(classList);
        }

        public IActionResult DeleteClass(int? id)
        {
            var obj = _db.Classes.Find(id);
            _db.Classes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("AdminHome", ad);
        }

        //-----Manage Teams---------
        public IActionResult ManageTeams(int? id)
        {
            Admin ad = _db.Admins.Find(id);
            List<Team> teamList = new List<Team>();
            IEnumerable<GroupCanEdit> gce = _db.GroupCanEdits.Where(
                x => x.AdminID == ad.AdminID
                );
            foreach (var c in gce)
            {
                teamList.Add(_db.Teams.Find(c.GID));
            }
            return View(teamList);
        }

        public IActionResult DeleteTeam(int? id)
        {
            var obj = _db.Teams.Find(id);
            _db.Teams.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("AdminHome", ad);
        }

        //-----Manage Performances---------
        public IActionResult ManagePerformances(int? id)
        {
            Admin ad = _db.Admins.Find(id);
            IEnumerable<Performance> perfList = _db.Performances;

            return View(perfList);
        }

        public IActionResult DeletePerformance(int? id)
        {
            var obj = _db.Teams.Find(id);
            _db.Teams.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("AdminHome", ad);
        }

    }
}
