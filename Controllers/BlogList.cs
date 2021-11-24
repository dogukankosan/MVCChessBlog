using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChessProject.Models.Entitiy;
namespace ChessProject.Controllers
{
    public class BlogList
    {//yandaki blog layoutun üst ve alt kısmı
        public IEnumerable<Tbl_Blog>ust { get; set; }
        public IEnumerable<Tbl_Blog> alt  { get; set; }
    }
}