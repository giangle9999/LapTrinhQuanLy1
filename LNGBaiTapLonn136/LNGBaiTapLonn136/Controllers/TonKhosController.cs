using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LNGBaiTapLonn136.Models;

namespace LNGBaiTapLonn136.Controllers
{
    public class TonKhosController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: TonKhos
        public ActionResult Index()
        {
            return View(db.TonKhos.ToList());
        }

        // GET: TonKhos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // GET: TonKhos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TonKhos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHangTon,TenHang,SoLuong")] TonKho tonKho)
        {
            if (ModelState.IsValid)
            {
                db.TonKhos.Add(tonKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tonKho);
        }

        // GET: TonKhos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // POST: TonKhos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHangTon,TenHang,SoLuong")] TonKho tonKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tonKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tonKho);
        }

        // GET: TonKhos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TonKho tonKho = db.TonKhos.Find(id);
            if (tonKho == null)
            {
                return HttpNotFound();
            }
            return View(tonKho);
        }

        // POST: TonKhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TonKho tonKho = db.TonKhos.Find(id);
            db.TonKhos.Remove(tonKho);
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
