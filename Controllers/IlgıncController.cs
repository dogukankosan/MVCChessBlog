using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class IlgıncController : Controller
    {
        ChessEntities db = new ChessEntities();
        public ActionResult Liste()
        {//İLGİNÇ BİLGİLER SAYFASI LİSTELİYORUZ
            try
            {
                var deger = db.Tbl_InterestingInfo.ToList();
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