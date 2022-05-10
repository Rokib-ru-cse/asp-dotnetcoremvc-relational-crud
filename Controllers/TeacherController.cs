using Aspdotnetmcvcrud.Data;
using Aspdotnetmcvcrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aspdotnetmcvcrud.Controllers;

public class TeacherController : Controller
{

    ApplicationDbContext _db;

    public TeacherController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var teachers = _db.Teachers.Include(t => t.Classroom);
        return View(teachers);
    }

    public IActionResult Delete(int id)
    {
        var t = _db.Teachers.Find(id);
        _db.Teachers.Remove(t);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Teacher teacher)
    {
        _db.Teachers.Add(teacher);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var t = _db.Teachers.Find(id);
        return View(t);
    }

    [HttpPost]
    public IActionResult Edit(Teacher teacher)
    {
        _db.Teachers.Update(teacher);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }



}