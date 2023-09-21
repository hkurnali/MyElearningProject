using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class CategoryController : Controller
    {
        ElearningContext db=new ElearningContext();
        public ActionResult Index()
        {
           
            var values = db.Categories.ToList();
            return View(values);
        }
        public ActionResult  DeleteCategory(int id) 
        {
            var values = db.Categories.Find(id);
            db.Categories.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.Categories.Find(id);
            return View(values);

        }


        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var values = db.Categories.Find(category.CategoryID);
            values.Name = category.Name;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View(db);
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
           db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}