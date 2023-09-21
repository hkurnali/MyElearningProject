using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class AboutController : Controller
    {
        ElearningContext db = new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Abouts.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.Abouts.Find(id);
            db.Abouts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Abouts.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var values = db.Abouts.Find(about.AboutID);
            values.Description = about.Description;
            values.Title1 = about.Title1;
            values.Title2 = about.Title2;
            values.Title3 = about.Title3;
            values.Title4 = about.Title4;
            values.Title5 = about.Title5;
            values.Title6 = about.Title6;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}