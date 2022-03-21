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
    public class XuatKhosController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: XuatKhos
        public ActionResult Index()
        {
            return View(db.XuatKhos.ToList());
        }

        // GET: XuatKhos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // GET: XuatKhos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: XuatKhos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuXuat,NgayXuat,MaHang,TenHang,SoLuong,DonGia,ThanhTien")] XuatKho xuatKho)
        {
            if (ModelState.IsValid)
            {
                db.XuatKhos.Add(xuatKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xuatKho);
        }

        // GET: XuatKhos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // POST: XuatKhos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuXuat,NgayXuat,MaHang,TenHang,SoLuong,DonGia,ThanhTien")] XuatKho xuatKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xuatKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xuatKho);
        }

        // GET: XuatKhos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // POST: XuatKhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            XuatKho xuatKho = db.XuatKhos.Find(id);
            db.XuatKhos.Remove(xuatKho);
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
