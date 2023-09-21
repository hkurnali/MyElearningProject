using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class TestimonialController : Controller
    {
        ElearningContext db = new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial)
        {
            db.Testimonials.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Testimonials.Find(id);
            db.Testimonials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonials.Find(id);
                return View(values);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
           var values=db.Testimonials.Find(testimonial.TestimonialID);
            values.Title = testimonial.Title;
            values.Comment = testimonial.Comment;
            values.ImageUrl = testimonial.ImageUrl;
            values.Status=testimonial.Status;
            values.NameSurname = testimonial.NameSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}