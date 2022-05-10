using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aspdotnetmcvcrud.Models;
using Aspdotnetmcvcrud.Data;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnetmcvcrud.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = _db.Students.Include(s => s.Classroom).ToList();
            return View(students);
        }

        public IActionResult Courses(int id)
        {
            var Students = _db.Courses.Where(c=>c.Students.Any(s=>s.Id==id));
            return View(Students);
        }

        public IActionResult Delete(int id){
            var s = _db.Students.Find(id);
            _db.Students.Remove(s);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}