using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CentricProject.DAL;
using CentricProject.Models;

namespace CentricProject.Controllers
{
    public class CoreValuesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: CoreValues
        public ActionResult Index()
        {
            return View(db.corevalue.ToList());
        }

        // GET: CoreValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoreValue coreValue = db.corevalue.Find(id);
            if (coreValue == null)
            {
                return HttpNotFound();
            }
            return View(coreValue);
        }

        // GET: CoreValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoreValues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "coreValueID,recognizer,recognized,recognitionDate")] CoreValue coreValue)
        {
            if (ModelState.IsValid)
            {
                db.corevalue.Add(coreValue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coreValue);
        }

        // GET: CoreValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoreValue coreValue = db.corevalue.Find(id);
            if (coreValue == null)
            {
                return HttpNotFound();
            }
            return View(coreValue);
        }

        // POST: CoreValues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "coreValueID,recognizer,recognized,recognitionDate")] CoreValue coreValue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coreValue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coreValue);
        }

        // GET: CoreValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoreValue coreValue = db.corevalue.Find(id);
            if (coreValue == null)
            {
                return HttpNotFound();
            }
            return View(coreValue);
        }

        // POST: CoreValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoreValue coreValue = db.corevalue.Find(id);
            db.corevalue.Remove(coreValue);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
