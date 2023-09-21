using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class MessageController : Controller
    {
      ElearningContext db=new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Messages.ToList();
            return View( values);
        }
        public ActionResult DeleteMessage(int id)
        { var values = db.Messages.Find(id);
            db.Messages.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}