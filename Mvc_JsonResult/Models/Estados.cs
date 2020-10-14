using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_JsonResult.Models
{
    public class Estados
    {
        public int Id  {get;set;}
        public string Nome { get; set; }

        public static List<Estados> GetEstados()
        {
            return new List<Estados>
            {
                new Estados(){Id=1,Nome="São paulo"},
                new Estados(){Id=2,Nome="Ceara"},
                new Estados(){Id=3,Nome="Bahia"},
                new Estados(){Id=4,Nome="Para"},
                new Estados(){Id=5,Nome="Alagoas"},
                new Estados(){Id=6,Nome="Parana"},

            };
        }
    }
}