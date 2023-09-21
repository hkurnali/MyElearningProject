using MyElearningProject.DAL.Context;
using MyElearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyElearningProject.Controllers
{
    public class ContactController : Controller
    {
        ElearningContext db = new ElearningContext();
        public ActionResult Index()
        {
            var values = db.Contacts.ToList();

            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.Contacts.Find(id);
            db.Contacts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.Contacts.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var values = db.Contacts.Find(contact.ContactID);
            values.Description = contact.Description;
            values.MapURL = contact.MapURL;
            values.Address = contact.Address;
            values.Email = contact.Email;
            values.Phone = contact.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}