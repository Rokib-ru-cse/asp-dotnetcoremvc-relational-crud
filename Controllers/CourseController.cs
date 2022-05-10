using Aspdotnetmcvcrud.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnetmcvcrud.Controllers;

public class CourseController:Controller{
    
    ApplicationDbContext _db;

    public CourseController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index(){
        var courses = _db.Courses;
        return View(courses);
    }

    public IActionResult Students(int id){
        var Students = _db.Students.Where(s=>s.Courses.Any(c=>c.Id==id)).Include(c=>c.Classroom);
        return View(Students);
    }

    public IActionResult Delete(int id){
        var c = _db.Courses.Find(id);
        _db.Courses.Remove(c);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

}