using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AdminHomeController : Controller
    {
        ChessEntities db = new ChessEntities();
        [Authorize]
        public ActionResult AnaSayfaDuzenle()
        {
            try
            {
                var deger = db.Tbl_Home.ToList();
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
        [Authorize]
        public ActionResult AnaSayfaAdd()
        {
            return View();
        }
        [Authorize]
        public ActionResult Add(Tbl_Home p)
        {
            try
            {
                var deger = db.Tbl_Home.Add(p);
                db.SaveChanges();
                return RedirectToAction("AnaSayfaDuzenle");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AnaSayfaDuzenle");
            }
        }
        [Authorize]
        public ActionResult Delete(byte id)
        {
            try
            {
                var deger = db.Tbl_Home.Find(id);
                db.Tbl_Home.Remove(deger);
                db.SaveChanges();
                return RedirectToAction("AnaSayfaDuzenle");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AnaSayfaDuzenle");
            }
        }
        [Authorize]
        public ActionResult UpdatePage(byte id)
        {
            try
            {
                var deger = db.Tbl_Home.Find(id); ;
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AnaSayfaDuzenle");
            }
        }
        [Authorize]
        public ActionResult UpdateGo(Tbl_Home p)
        {
            try
            {
                var deger = db.Tbl_Home.Find(p.ID);
                deger.Title = p.Title;
                deger.Comment = p.Comment;
                deger.Image = p.Image;
                db.SaveChanges();
                return RedirectToAction("AnaSayfaDuzenle");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("AnaSayfaDuzenle");
            }
        }
    }
}