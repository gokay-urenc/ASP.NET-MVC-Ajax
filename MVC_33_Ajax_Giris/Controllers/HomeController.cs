using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_33_Ajax_Giris.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hesapla(int sayi1, int sayi2)
        {
            return View(sayi1 + sayi2);
        }

        public ActionResult AjaxHesapla(int sayi1, int sayi2)
        {
            // Ajax 3 tip veri dönebilir. Json formatı, Partial View, img,png
            return Json(sayi1 + sayi2, JsonRequestBehavior.AllowGet);
        }
    }
}