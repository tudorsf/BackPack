using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPack
{
    public class BackPack
    {   
        public int TotalNr { get; set; }
        public double TotalWeight { get; set; }
        public double TotalVolume { get; set; }
        public List<Inventory> Articles { get; set; }

        public BackPack(int totalNr, double totalWeight, double totalVolume)
        {
            TotalNr = totalNr;
            TotalWeight = totalWeight;
            TotalVolume = totalVolume;
        }
        public bool Add(Inventory article)
        {
            var greutateDupaAdaugare = article.Weight + Articles.Sum(x => x.Weight);
            var volumDupaAdaugare = article.Volume + Articles.Sum(x => x.Volume);
            var obiecteDupaAdaugare = Articles.Count() + 1;
            if(greutateDupaAdaugare < TotalWeight && volumDupaAdaugare < TotalVolume && obiecteDupaAdaugare < TotalVolume)
            {
                Articles.Add(article);
                return true;
            }
            return false;
        }
    }
}
