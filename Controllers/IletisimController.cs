using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class IletisimController : Controller
    {
        ChessEntities db = new ChessEntities();
        public ActionResult iletisim()
        {//iletişim sayfası döner
            return View();
        }
        public ActionResult Gonder(Tbl_Contact p)
        {// bize ulaşabilmeleri için tabloya ekleme yapıyoruz
            try
            {
                p.Date = DateTime.Now;
                db.Tbl_Contact.Add(p);
                db.SaveChanges();
                return RedirectToAction("iletisim");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("iletisim");
            }
        }
    }
}