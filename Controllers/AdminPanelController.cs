using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AdminPanelController : Controller
    {//MODELİM EF
        ChessEntities db = new ChessEntities();
        [Authorize]
        public ActionResult AdminAna()
        {// BLOG LİSTELEME YAPAR
            try
            {
                var deger = db.Tbl_Blog.ToList();
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
        [Authorize]
        public ActionResult Delete(Int16 id)
        {// BLOG SİLME İŞLEMİ YAPAR
            try
            {
                var deger = db.Tbl_Blog.Find(id);
                db.Tbl_Blog.Remove(deger);
                db.SaveChanges();
                return RedirectToAction("AdminAna");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AdminAna");
            }
        }
        [Authorize]
        public ActionResult Add()
        {   //BLOG EKLEME SAYFASINI AÇAR
            return View();
        }
        [Authorize]
        public PartialViewResult BlogDetayAdd()
        {// BLOG EKLEME SAYFASINDA BLOG DETAY TABLOSUNA EKLEMEK İÇİN MODELİ GETİRİR
            return PartialView();
        }
        [Authorize]
        public ActionResult AddGo(Tbl_Blog p, TblDetay k)
        {//BLOG EKLEME İŞLEMİ YAPAR
            try
            {
                k.BlogID = p.ID;
                db.Tbl_Blog.Add(p);
                db.TblDetay.Add(k);
                db.SaveChanges();
                return RedirectToAction("AdminAna");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Add");
            }
        }
        [Authorize]
        public ActionResult UpdatePage(Int16 id)
        {//GÜNCELLEME SAYFASINA GİDİŞ
            try
            {
                var deger = db.Tbl_Blog.Find(id);
                TempData["id"] = id;
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AdminAna");
            }
        }
        [Authorize]
        public PartialViewResult BlogDetayUpdate()
        {// BLOG GÜNCELLEME SAYFASINDA BLOG DETAY TABLOSUNu GÜNCELLEMEK İÇİN MODELİ GETİRİR
            try
            {
                Int16 id = Convert.ToInt16(TempData["id"]);
                var deger = db.TblDetay.Where(x => x.BlogID == id).FirstOrDefault();
                return PartialView(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return PartialView("AdminAna");
            }
        }
        [Authorize]
        public ActionResult UpdateGo(Tbl_Blog p, TblDetay k)
        {// BLOG GÜNCELLEME
            try
            {
                var blog = db.Tbl_Blog.Find(p.ID);
                blog.BlogTitle = p.BlogTitle;
                blog.BlogComment = p.BlogComment;
                blog.BlogImage = p.BlogImage;
                blog.BlogDate = p.BlogDate;
                var blogdetay = db.TblDetay.Where(x => x.BlogID == p.ID).FirstOrDefault();
                blogdetay.BlogImage1 = k.BlogImage1;
                blogdetay.BlogImage2 = k.BlogImage2;
                blogdetay.BlogComment1 = k.BlogComment1;
                blogdetay.BlogComment2 = k.BlogComment2;
                blogdetay.BlogSoz = k.BlogSoz;
                db.SaveChanges();
                return RedirectToAction("AdminAna");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AdminAna");
            }
        }
    }
}