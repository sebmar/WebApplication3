using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.DAL;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class InformacjasController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Informacjas
        public ActionResult Index()
        {
            return View(db.Informacjas.ToList());
        }

        // GET: Informacjas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informacja informacja = db.Informacjas.Find(id);
            if (informacja == null)
            {
                return HttpNotFound();
            }
            return View(informacja);
        }

        // GET: Informacjas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Informacjas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,ShortDescription,Description,PostedOn")] Informacja informacja)
        {
            if (ModelState.IsValid)
            {
                db.Informacjas.Add(informacja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(informacja);
        }

        // GET: Informacjas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informacja informacja = db.Informacjas.Find(id);
            if (informacja == null)
            {
                return HttpNotFound();
            }
            return View(informacja);
        }

        // POST: Informacjas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,ShortDescription,Description,PostedOn")] Informacja informacja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(informacja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(informacja);
        }

        // GET: Informacjas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Informacja informacja = db.Informacjas.Find(id);
            if (informacja == null)
            {
                return HttpNotFound();
            }
            return View(informacja);
        }

        // POST: Informacjas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Informacja informacja = db.Informacjas.Find(id);
            db.Informacjas.Remove(informacja);
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
