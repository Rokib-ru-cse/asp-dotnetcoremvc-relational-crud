using Aspdotnetmcvcrud.Data;
using Aspdotnetmcvcrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnetmcvcrud.Controllers
{
    public class ClassroomController : Controller
    {
        ApplicationDbContext _db;

        public ClassroomController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Classrooms = _db.Classrooms.Include(c => c.Teacher);
            return View(Classrooms);
        }

        [HttpGet]
        public IActionResult Students(int id)
        {
            var students = _db.Students.Where(s => s.ClassroomId == id).Include(s => s.Classroom);
            return View(students);
        }

        public IActionResult Delete(int id)
        {
            var cr = _db.Classrooms.Find(id);
            _db.Classrooms.Remove(cr);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Classroom cr)
        {
            _db.Classrooms.Add(cr);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}