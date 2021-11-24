using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AdminYorumController : Controller
    {
        ChessEntities db = new ChessEntities();
        [Authorize]
        public ActionResult YorumListe()
        {//YORUM LİSTESİ
            try
            {
                var deger = db.Tbl_Comment.ToList();
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
        [Authorize]
        public ActionResult TrueComment(Int16 id)
        {
            try
            {
                var deger = db.Tbl_Comment.Find(id);
                deger.CommentOkay = true;
                db.SaveChanges();
                return RedirectToAction("YorumListe");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("YorumListe");
            }
        }
        [Authorize]
        public ActionResult UpdatePage(Int16 id)
        {
            try
            {
                var deger = db.Tbl_Comment.Find(id);
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("YorumListe");
            }
        }
        [Authorize]
        public ActionResult FalseComment(Int16 id)
        {
            try
            {
                var deger = db.Tbl_Comment.Find(id);
                deger.CommentOkay = false;
                db.SaveChanges();
                return RedirectToAction("YorumListe");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("YorumListe");
            }

        }
        [Authorize]
        public ActionResult UpdateGo(Tbl_Comment p)
        {
            try
            {
                var deger = db.Tbl_Comment.Find(p.ID);
                deger.Name = p.Name;
                deger.Mail = p.Mail;
                deger.Comment = p.Comment;
                db.SaveChanges();
                return RedirectToAction("YorumListe");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("YorumListe");
            }
        }
    }
}