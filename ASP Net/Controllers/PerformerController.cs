using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicMakerProgram.Data;
using MusicMakerProgram.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicMakerProgram.Controllers
{
    public class PerformerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PerformerController(ApplicationDBContext db)
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
        public IActionResult Login(Performer p)
        {

            Performer userDetails = _db.Performers.Where(
                x => x.Name == p.Name
            ).SingleOrDefault();

            if (userDetails == null)
            {
                return RedirectToAction("Create");
            }
            return RedirectToAction("DisplayPerformerView", userDetails);
        }

        //------------REGISTER------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // POST - create
        public IActionResult Create(Performer p)
        {
            _db.Performers.Add(p);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Failed()
        {
            return View();
        }

        //--------PERFORMER VIEW -------------
        [HttpGet]
        public IActionResult DisplayPerformerView(Performer performer)
        {
            List<Piece> piecesList = new List<Piece>();
            var k = _db.KnowsS.Where(
                a => a.PerformerID  == performer.PerformerID);
            foreach (var c in k)
            {
                piecesList.Add(_db.Pieces.Find(c.PieceID));
            }

            return View(piecesList);
        }


        //-----------Composer View--------------------
        public IActionResult DisplayComposer(int? id)
        {
            var obj = _db.Composers.Find(id);
            if(obj != null)
            {
                return View(obj);
            }
            return RedirectToAction("Index");
        }
    }
}
