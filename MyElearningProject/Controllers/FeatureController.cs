using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class FeatureController : Controller
    {
       ElearningContext db=new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Features.ToList();
            return View(values);
        }
        public ActionResult DeleteFeature(int id) 
        {
            var values = db.Features.Find(id);
            db.Features.Remove(values);
            return RedirectToAction("Index");
        
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {  var values = db.Features.Find(id);
            return View(values);
        
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature feature)
        {
            var values = db.Features.Find(feature.FeatureID);
            values.Title = feature.Title;
            values.Description=feature.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}