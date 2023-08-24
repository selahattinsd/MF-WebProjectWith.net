using MfWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MfWebProject.Controllers
{
    public class UsersController : Controller
    {
        OtomasyonContainer db = new OtomasyonContainer();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.OgrencilerSets.ToList());
        }
        public ActionResult yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeni(OgrencilerSet save)
        {
            db.OgrencilerSets.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Index2()
        {
            return View(db.OgrencilerSets.ToList());
        }
        [HttpGet]
        public ActionResult Yeni2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeni2(OgrencilerSet kaydet)
        {
            db.OgrencilerSets.Add(kaydet);
            db.SaveChanges();

            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.OgrencilerSets.Where(x => x.OgrenciNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, OgrencilerSet yenile)
        {
            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.OgrencilerSets.Where(x => x.OgrenciNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, OgrencilerSet sil)
        {
            sil = db.OgrencilerSets.Where(x => x.OgrenciNo == id).FirstOrDefault();
            db.OgrencilerSets.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

    }
}