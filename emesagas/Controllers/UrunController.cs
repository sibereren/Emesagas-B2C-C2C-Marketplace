using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmesagasData;
using emesagas.Models;

namespace emesagas.Controllers
{
    public class UrunController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Urun
        public ActionResult Index()
        {
            return View(db.Uruns.ToList());
        }

        // GET: Urun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uruns uruns = db.Uruns.Find(id);
            if (uruns == null)
            {
                return HttpNotFound();
            }
            return View(uruns);
        }

        // GET: Urun/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Urun/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrunsId,UyeId,UrunAdi,UrunStokAdedi,UrunStokKalan,UrunStokSatilan,UrunFiyati,UrunAciklama,UrunEklenmeTarihi,IlanAktifMi,UrunKisaAciklama,UrunGuncellenmeTarihi")] Uruns uruns)
        {
            if (ModelState.IsValid)
            {
                db.Uruns.Add(uruns);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uruns);
        }

        // GET: Urun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uruns uruns = db.Uruns.Find(id);
            if (uruns == null)
            {
                return HttpNotFound();
            }
            return View(uruns);
        }

        // POST: Urun/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrunsId,UyeId,UrunAdi,UrunStokAdedi,UrunStokKalan,UrunStokSatilan,UrunFiyati,UrunAciklama,UrunEklenmeTarihi,IlanAktifMi,UrunKisaAciklama,UrunGuncellenmeTarihi")] Uruns uruns)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uruns).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uruns);
        }

        // GET: Urun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uruns uruns = db.Uruns.Find(id);
            if (uruns == null)
            {
                return HttpNotFound();
            }
            return View(uruns);
        }

        // POST: Urun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uruns uruns = db.Uruns.Find(id);
            db.Uruns.Remove(uruns);
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
