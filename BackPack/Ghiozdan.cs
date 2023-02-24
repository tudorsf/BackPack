using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack
{
    public class Ghiozdan
    {   
        public int NrTotal { get; set; }
        public double TotalGreutate { get; set; }
        public double TotalVolum { get; set; }
        public List<ArticolInventar> Articole { get; set; }

        public Ghiozdan(int nrTotal, double totalGreutate, double totalVolum)
        {
            NrTotal = nrTotal;
            TotalGreutate = totalGreutate;
            TotalVolum = totalVolum;
        }
        public bool Adauga(ArticolInventar articol)
        {
            var greutateDupaAdaugare = articol.Greutate + Articole.Sum(x => x.Greutate);
            var volumDupaAdaugare = articol.Volum + Articole.Sum(x => x.Volum);
            var obiecteDupaAdaugare = Articole.Count() + 1;
            if(greutateDupaAdaugare < TotalGreutate && volumDupaAdaugare < TotalVolum && obiecteDupaAdaugare < TotalVolum)
            {
                Articole.Add(articol);
                return true;
            }
            return false;
        }
    }
}
