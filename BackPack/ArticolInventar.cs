using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack
{
    public class ArticolInventar
    {   
        public double Greutate { get; set; }
        public double Volum { get; set; }
        public ArticolInventar(double greutate, double volum)
        {
            Greutate = greutate;
            Volum = volum;
        }
    }
}
