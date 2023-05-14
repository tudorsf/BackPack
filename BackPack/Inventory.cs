using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack
{
    public class Inventory
    {   
        public double Weight { get; set; }
        public double Volume { get; set; }
        public Inventory(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}
