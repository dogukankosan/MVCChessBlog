using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class Homelist
    {// bir sayfaya birden fazla tablodan veri çekerken lazım alanlarımız
        public IEnumerable<Tbl_Home>home { get; set; }
        public IEnumerable<Tbl_Blog>blog { get; set; }
        public IEnumerable<Tbl_Comment> comment { get; set; }
    }
}