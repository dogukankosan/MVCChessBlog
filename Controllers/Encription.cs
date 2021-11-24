using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessProject.Controllers
{
    public class Encription
    {
        public static string Coz(string text)
        {
            char[] dizi = text.ToCharArray();
            string sifrele = string.Empty;
            foreach (var item in dizi)
            {
                sifrele += Convert.ToChar(item - 3);
            }
            return sifrele;
        }
    }
}