using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class StudentController : Controller
    {
       ElearningContext db=new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Students.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteStudent(int id)
        {
            var values = db.Students.Find(id);
            db.Students.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var values=db.Students.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        { var values=db.Students.Find(student.StudentID); 
            values.Surname = student.Surname;
            values.Name = student.Name;
            values.Email= student.Email;
            values.Password = student.Password;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}