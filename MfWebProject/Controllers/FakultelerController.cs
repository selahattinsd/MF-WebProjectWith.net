using MfWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MfWebProject.Controllers
{
    public class FakultelerController : Controller
    {
        OtomasyonContainer db = new OtomasyonContainer();

        // GET: Fakulteler
        public ActionResult Index()
        {
            return View(db.FakultelerSets.ToList());
        }
        public ActionResult Index2()
        {
            return View(db.FakultelerSets.ToList());
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeni(FakultelerSet kaydet)
        {
            db.FakultelerSets.Add(kaydet);
            db.SaveChanges();

            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.FakultelerSets.Where(x => x.FakulteNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, FakultelerSet yenile)
        {
            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(db.FakultelerSets.Where(x => x.FakulteNo == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, FakultelerSet sil)
        {
            sil = db.FakultelerSets.Where(x => x.FakulteNo == id).FirstOrDefault();
            db.FakultelerSets.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
    }
}