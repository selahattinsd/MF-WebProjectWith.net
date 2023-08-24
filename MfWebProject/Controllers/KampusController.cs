using MfWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MfWebProject.Controllers
{
    public class KampusController : Controller
    {
        OtomasyonContainer db = new OtomasyonContainer();   

        // GET: Kampus
        public ActionResult Index()
        {
            return View(db.KampuslerSets.ToList());
        }
        public ActionResult Index2()
        {
            return View(db.KampuslerSets.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeni(KampuslerSet kaydet)
        {
            db.KampuslerSets.Add(kaydet);
            db.SaveChanges();

            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.KampuslerSets.Where(x => x.KampusNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, KampuslerSet yenile)
        {
            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.KampuslerSets.Where(x => x.KampusNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, KampuslerSet sil)
        {
            sil = db.KampuslerSets.Where(x => x.KampusNo == id).FirstOrDefault();
            db.KampuslerSets.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
    }
}