using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AnasayfaController : Controller
    {
        ChessEntities db = new ChessEntities();
        public ActionResult Home()
        {//ANA SAYFADAKİ VERİLERİ ÇEKİYORUM
            try
            {
                Homelist ls = new Homelist();
                ls.blog = db.Tbl_Blog.OrderByDescending(x => x.ID).Take(3).ToList();
                ls.home = db.Tbl_Home.ToList();
                ls.comment = db.Tbl_Comment.OrderByDescending(x => x.ID).Where(x=>x.CommentOkay==true).Take(3).ToList();
                return View(ls);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }

        }
        public PartialViewResult Layoutwett()
        {  //LAYOUTTAKİ TWETTLERİ ÇEKİYOR
            try
            {
                var deger = db.TblDetay.OrderByDescending(x => x.ID).Take(3).ToList();
                return PartialView(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return PartialView();
            }
        }
        public PartialViewResult InfoInsterting()
        {  // İLGİNÇ BİLGİLERDEN 2 TANE VERİ ÇEKİYORUZ
            try
            {
                var deger = db.Tbl_InterestingInfo.OrderByDescending(x => x.ID).Take(2).ToList();
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