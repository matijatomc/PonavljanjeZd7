using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPonavlajnjeZd7
{
    class GeometriskoTijelo
    {
        double volumen;
        double oplosje;
        public static int brojacTijela;

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }

        public GeometriskoTijelo()
        {
            brojacTijela++;
        }
    }
}
