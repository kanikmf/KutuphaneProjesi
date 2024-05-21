using KutuphaneProjesi.Models;
using KutuphaneProjesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneProjesi.Controllers
{
    public class ElektronikYayınTalepController : Controller
    {
        ElektronikYayınTalepRepository elektronikYayınTalepRepository = new ElektronikYayınTalepRepository();

        [Authorize]
        public IActionResult Index()
        {
            var ct = elektronikYayınTalepRepository.TList().Where(x => x.IsActive == true).ToList();
            return View(ct);
        }
        [HttpGet]
        public IActionResult ElektronikYayınAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ElektronikYayınAdd(ElektronikYayinTalep p)
        {
            p.IsActive = true;
            elektronikYayınTalepRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult ElektronikYayınGet(int id)
        {
            var x = elektronikYayınTalepRepository.TGet((id));
            ElektronikYayinTalep ct = new ElektronikYayinTalep()
            {
                YazarID = x.YazarID,
                YazarAdı = x.YazarAdı,
                YayınAdı = x.YayınAdı,
                YayınEvi = x.YayınEvi,
                Eisbn = x.Eisbn,
                Nitelik = x.Nitelik,

            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult ElektronikYayınTalepUpdate(ElektronikYayinTalep p)
        {
            var x = elektronikYayınTalepRepository.TGet(p.YazarID);
            x.YazarAdı = p.YazarAdı;
            x.YayınAdı = p.YayınAdı;
            x.YayınEvi = p.YayınEvi;
            x.Eisbn = p.Eisbn;
            x.Nitelik = p.Nitelik;
            elektronikYayınTalepRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult ElektronikYayınTalepDelete(int id)
        {
            var x = elektronikYayınTalepRepository.TGet(id);
            x.IsActive = false;
            elektronikYayınTalepRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}

    

