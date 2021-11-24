using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class AdminIletisimController : Controller
    {
        ChessEntities db = new ChessEntities();
        [Authorize]
        public ActionResult IletisimList()
        {
            try
            {
            var deger = db.Tbl_Contact.ToList();
            return View(deger);
            }
            catch (Exception a)
            {
                Response.Write("<script lang='JavaScript'>alert('" + a.Message + "');</script>");
                return View();
            }
        }
    }
}