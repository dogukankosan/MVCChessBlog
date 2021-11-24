using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AdminIlgincController : Controller
    {
        ChessEntities db = new ChessEntities();
        [Authorize]
        public ActionResult Listele()
        {
            var deger = db.Tbl_InterestingInfo.ToList();
            return View(deger);
        }
        [Authorize]
        public ActionResult AnaSayfaAdd()
        {
            return View();
        }
        [Authorize]
        public ActionResult Add(Tbl_InterestingInfo p)
        {
            try
            {
                var deger = db.Tbl_InterestingInfo.Add(p);
                db.SaveChanges();
                return RedirectToAction("Listele");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Listele");
            }
        }
        [Authorize]
        public ActionResult Delete(byte id)
        {
            try
            {
                var deger = db.Tbl_InterestingInfo.Find(id);
                db.Tbl_InterestingInfo.Remove(deger);
                db.SaveChanges();
                return RedirectToAction("Listele");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Listele");
            }
        }
        [Authorize]
        public ActionResult UpdatePage(byte id)
        {
            try
            {
                var deger = db.Tbl_InterestingInfo.Find(id); ;
                return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Listele");
            }
        }
        [Authorize]
        public ActionResult UpdateGo(Tbl_InterestingInfo p)
        {
            try
            {
                var deger = db.Tbl_InterestingInfo.Find(p.ID);
                deger.Interesting = p.Interesting;
                deger.Information = p.Information;
                deger.Who = p.Who;
                db.SaveChanges();
                return RedirectToAction("Listele");
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View("Listele");
            }
        }
    }
}