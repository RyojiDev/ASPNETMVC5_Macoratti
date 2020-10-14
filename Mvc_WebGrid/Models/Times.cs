using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_WebGrid.Models
{
    public class Times
    {
        public string Time { get; set; }
        public int Jogos { get; set; }

        public int Pontos { get; set; }

        public static List<Times> getTimes()
        {
            return new List<Times> {
            new Times { Time = "São Paulo", Jogos = 15, Pontos = 34 },
                new Times { Time = "Corinthians", Jogos = 15, Pontos = 34 },
                new Times { Time = "Palmeiras", Jogos = 15, Pontos = 32 },
                new Times { Time = "Santos", Jogos = 15, Pontos = 30 },
                new Times { Time = "Mogi Mirim", Jogos = 15, Pontos = 30 },
                new Times { Time = "Guarani", Jogos = 15, Pontos = 27 },
                new Times { Time = "Ponte Preta", Jogos = 15, Pontos = 25 },
                new Times { Time = "Bragantino", Jogos = 15, Pontos = 23 },
                new Times { Time = "Paulista", Jogos = 15, Pontos = 19 },
                new Times { Time = "Linense", Jogos = 15, Pontos = 19 },
                new Times { Time = "Ituano", Jogos = 15, Pontos = 18 },
                new Times { Time = "Mirassol", Jogos = 15, Pontos = 18 },
                new Times { Time = "Portuguesa", Jogos = 15, Pontos = 17 },
                new Times { Time = "São Caetano", Jogos = 15, Pontos = 16 },
                new Times { Time = "Oeste", Jogos = 15, Pontos = 16 },
                new Times { Time = "Catanduvense", Jogos = 15, Pontos = 13 },
                new Times { Time = "XV de Piracicaba", Jogos = 15, Pontos = 11 },
                new Times { Time = "Guaratinguetá", Jogos = 15, Pontos = 11 },
                new Times { Time = "Botafogo", Jogos = 15, Pontos = 10 },
                new Times { Time = "Comercial", Jogos = 15, Pontos = 8 }
        };

        }

    }
}