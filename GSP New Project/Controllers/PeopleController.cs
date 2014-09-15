using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GSPNewProject.Models;

namespace GSPNewProject.Controllers
{
    public class PeopleController : Controller
    {

		#region Views

        public ActionResult Index()
        {
            return View(_db.Persons.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var person = _db.Persons.Find(id);
            if (person == null) return HttpNotFound();
            return View(person);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DateAdded,Name,Age,BirthDate,PhoneNumber,EmailAddress,Comment,Address1,Address2,City,State,Zip")] Person person)
        {
            if (ModelState.IsValid)
            {
                _db.Persons.Add(person);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var person = _db.Persons.Find(id);
            if (person == null) return HttpNotFound();
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DateAdded,Name,Age,BirthDate,PhoneNumber,EmailAddress,Comment,Address1,Address2,City,State,Zip")] Person person)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(person).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var person = _db.Persons.Find(id);
            if (person == null) return HttpNotFound();
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var person = _db.Persons.Find(id);
            _db.Persons.Remove(person);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

		#endregion

		#region JSON


		#endregion

		#region Helpers

		private readonly ProjectContext _db = new ProjectContext();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

		#endregion
    }
}
