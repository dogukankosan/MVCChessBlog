using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers.Admin
{
    public class LoginController : Controller
    {
        ChessEntities db = new ChessEntities();
        [HttpGet]
        public ActionResult GirisYap()
        {//GİRİŞ SAYFASI DÖNER
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Tbl_Admin p)
        {//GİRİŞ YAPABİLECEK Mİ DOĞRU GİRDİ Mİ ŞİFREYİ KULLANICI ADINI KONTROL EDİYORUZ COOKİE İLEDE GİRİŞ YAPTIĞINDA TEKRAR SORMASIN DİYE ATIYORUZ
            var deger1 = db.Tbl_Admin.Take(1).ToList();
            string id=string.Empty, sifre=string.Empty;
            foreach (var item in deger1)
            {
                id = Encription.Coz(item.UserName);
                sifre = Encription.Coz(item.Password);
            }
            if (id==p.UserName && sifre==p.Password)
            {
                FormsAuthentication.SetAuthCookie(p.UserName, false);
                Session["Username"] = p.UserName;
                return RedirectToAction("AdminAna", "AdminPanel");
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('HATALI GİRİŞ YAPILDI TEKRAR GİRİNİZ !!');</script>");
                return View();
            }

        }
        public ActionResult Logout()
        {//ÇIKIŞ İŞLEMİ YAPIYORUZ
            FormsAuthentication.SignOut();
            return RedirectToAction("Home", "Anasayfa");
        }
    }
}