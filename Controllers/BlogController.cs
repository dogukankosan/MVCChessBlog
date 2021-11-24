using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
using PagedList.Mvc;
using PagedList;
namespace ChessProject.Controllers
{
    public class BlogController : Controller
    {
        ChessEntities db = new ChessEntities();
        public ActionResult Sayfa(byte sayfa = 1)
        {//BLOG LİSTESİ ALIYORUZ
            try
            {
                var deger = db.Tbl_Blog.OrderByDescending(x => x.ID).ToList().ToPagedList(sayfa, 2);
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
        public ActionResult Detay(Int16 id)
        {//BLOGLARIN DETAYLARINI GETİYORUZ
            try
            {
                var deger = db.TblDetay.Where(x => x.BlogID == id).ToList();
                TempData["value"] = id.ToString();
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
        public ActionResult CommentEkle(Tbl_Comment p)
        {//YORUM EKLEME YAPIYORUZ
            try
            {
                p.BlogID = Convert.ToInt16(TempData["value"]);
                p.Date = DateTime.Now;
                db.Tbl_Comment.Add(p);
                db.SaveChanges();
                return RedirectToAction("Sayfa");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Sayfa");
            }
        }
        public PartialViewResult CommentAdd()
        {
            return PartialView();
        }
        public PartialViewResult BlogList()
        {// YANDAKİ LAYOUT KISMINDAKİ YERLERİ LİSTELİYORUZ
            try
            {
                BlogList ls = new BlogList();
                ls.alt = db.Tbl_Blog.OrderByDescending(x => x.ID).Take(5).ToList();
                ls.ust = db.Tbl_Blog.Take(1).ToList();
                return PartialView(ls);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return PartialView();
            }
        }
        public PartialViewResult CommentList()
        {//YORUMLARI LİSTELİYORUZ
            try
            {
                Int16 id = Convert.ToInt16(TempData["value"]);
                TempData["value"] = id.ToString();
                var deger = db.Tbl_Comment.Where(x => x.BlogID == id && x.CommentOkay == true).ToList();
                return PartialView(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return PartialView();
            }
        }
    }
}