using MfWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MfWebProject.Controllers
{
    public class AkademisyenlerController : Controller
    {
        OtomasyonContainer db = new OtomasyonContainer();

        // GET: Akademisyenler
        public ActionResult Index()
        {
            return View(db.AkademisyenlerSets.ToList());
        }
        public ActionResult Index2()
        {
            return View(db.AkademisyenlerSets.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult yeni(AkademisyenlerSet kaydet)
        {
            db.AkademisyenlerSets.Add(kaydet);
            db.SaveChanges();

            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.AkademisyenlerSets.Where(x => x.AkademiNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, AkademisyenlerSet yenile)
        {
            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db. AkademisyenlerSets.Where(x => x.AkademiNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, AkademisyenlerSet sil)
        {
            sil = db.AkademisyenlerSets.Where(x => x.AkademiNo == id).FirstOrDefault();
            db.AkademisyenlerSets.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

    }
}