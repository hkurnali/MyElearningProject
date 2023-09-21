using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class InstructorController : Controller
    {
        ElearningContext db = new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Instructors.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInstructor() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInstructor(Instructor instructor)
        { 
             db.Instructors.Add(instructor);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateInstructor(int id)
        {
            var values = db.Instructors.Find(id);
            return View(values);

        }

        [HttpPost]
        public ActionResult UpdateInstructor(Instructor instructor)
        {
            var values = db.Instructors.Find(instructor.InstructorID);
                values.Name = instructor.Name;
            values.Surname = instructor.Surname;
            values.Image=instructor.Image;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteInstructor(int id)
        {
            var values=db.Instructors.Find(id);
            db.Instructors.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}