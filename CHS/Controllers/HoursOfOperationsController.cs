using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CHS.Models;

namespace CHS.Controllers
{
    public class HoursOfOperationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HoursOfOperations
        public ActionResult Index()
        {
            var hoursOfOperations = db.HoursOfOperations.ToList();
            return View(hoursOfOperations);
        }

        [Authorize]
        public ActionResult ManageContent()
        {
            return View(db.HoursOfOperations.ToList());
        }

        // GET: HoursOfOperations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursOfOperation hoursOfOperation = db.HoursOfOperations.Find(id);
            if (hoursOfOperation == null)
            {
                return HttpNotFound();
            }
            return View(hoursOfOperation);
        }

        // GET: HoursOfOperations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HoursOfOperations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,dayOfWeek,openTime,closeTime,status")] HoursOfOperation hoursOfOperation)
        {
            if (ModelState.IsValid)
            {
                db.HoursOfOperations.Add(hoursOfOperation);
                db.SaveChanges();
                return RedirectToAction("ManageContent");
            }

            return View(hoursOfOperation);
        }

        // GET: HoursOfOperations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursOfOperation hoursOfOperation = db.HoursOfOperations.Find(id);
            if (hoursOfOperation == null)
            {
                return HttpNotFound();
            }
            return View(hoursOfOperation);
        }

        // POST: HoursOfOperations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,dayOfWeek,openTime,closeTime,status")] HoursOfOperation hoursOfOperation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoursOfOperation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ManageContent");
            }
            return View(hoursOfOperation);
        }

        // GET: HoursOfOperations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursOfOperation hoursOfOperation = db.HoursOfOperations.Find(id);
            if (hoursOfOperation == null)
            {
                return HttpNotFound();
            }
            return View(hoursOfOperation);
        }

        // POST: HoursOfOperations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoursOfOperation hoursOfOperation = db.HoursOfOperations.Find(id);
            db.HoursOfOperations.Remove(hoursOfOperation);
            db.SaveChanges();
            return RedirectToAction("ManageContent");
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
