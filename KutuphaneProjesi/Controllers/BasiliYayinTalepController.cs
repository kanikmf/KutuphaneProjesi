using KutuphaneProjesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using KutuphaneProjesi.Models;
using System.Net.WebSockets;
namespace KutuphaneProjesi.Controllers
{
    public class BasiliYayinTalepController : Controller
    {

        BasiliYayinTalepRepository basiliYayinTalepRepository = new BasiliYayinTalepRepository();
        [Authorize]
        public IActionResult Index()
        {
            var ct = basiliYayinTalepRepository.TList().Where(x => x.İsActive == true).ToList();
            return View(ct);
        }
        [HttpGet]
        public IActionResult BasiliYayinAdd()
        {
            var ct = basiliYayinTalepRepository.TList().Where(x => x.İsActive == true).ToList();
            return View(ct);
        }
        [HttpPost]
        public IActionResult BasiliYayinAdd(BasiliYayinTalep p)
        {
            p.İsActive = true;
            basiliYayinTalepRepository.TAdd(p);
            return View();
        }
        public IActionResult BasiliYayinTalepGet(int id)
        {
            var x = basiliYayinTalepRepository.TGet((id));
            BasiliYayinTalep ct = new BasiliYayinTalep()
            {
                BasılıYayınID = x.BasılıYayınID,
                Yazar = x.Yazar,
                YayınAdı = x.YayınAdı,
                Isbn = x.Isbn,
                YayinEvi = x.YayinEvi,
                YayınTarihi = x.YayınTarihi,

            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult BasiliYayinTalepUpdate(BasiliYayinTalep p)
        {
            var x = basiliYayinTalepRepository.TGet(p.BasılıYayınID);
            x.Yazar = p.Yazar;
            x.YayınAdı = p.YayınAdı;
            x.Isbn = p.Isbn;
            x.YayinEvi = p.YayinEvi;
            x.YayınTarihi = p.YayınTarihi;
            basiliYayinTalepRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("BasiliYayinTalep/BasiliYayinDelete/{id}")]
        public JsonResult BasiliYayinDelete(int id)

        {
            var x = basiliYayinTalepRepository.TGet(id);
            x.İsActive = false;
            basiliYayinTalepRepository.TUpdate(x);
            return Json(new { isSuccess = true, message = "Kayıt başarıyla silindi." });
        }
    }
}
