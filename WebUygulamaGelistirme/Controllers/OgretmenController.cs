using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirme.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Listele()
        {
            return View(Models.OgretmenVeri.Ogretmenler);


        }
        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Models.Ogretmen yeniOgretmen)
        {
            Models.OgretmenVeri.Ogretmenler.Add(yeniOgretmen);
            return RedirectToAction("Listele");
        }
        public IActionResult Guncelle(int id)
        {
            var r = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Guncelle(Models.Ogretmen ogretmen)
        {
            var c = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == ogretmen.Id);
            var r = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == ogretmen.Id);
            r.Ad = ogretmen.Ad;
            r.Soyad = ogretmen.Soyad;
            r.Bolum = ogretmen.Bolum;
            r.TCKimlikNo = ogretmen.TCKimlikNo;
            r.Yas = ogretmen.Yas;
            Models.OgretmenVeri.Ogretmenler.Remove(c);
            Models.OgretmenVeri.Ogretmenler.Add(r);

            return RedirectToAction("Listele");
        }
        public IActionResult Detay(int id)
        {
            var r = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        public IActionResult Sil(int id)
        {
            var r = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }
        [HttpPost]
        public IActionResult Sil(Models.Ogretmen ogretmen)
        {
            var r = Models.OgretmenVeri.Ogretmenler.FirstOrDefault(x => x.Id == ogretmen.Id);
            Models.OgretmenVeri.Ogretmenler.Remove(r);
            return RedirectToAction("Listele");
        }
    }
}