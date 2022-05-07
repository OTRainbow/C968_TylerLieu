using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_TylerLieu
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
        {
            this.PartID = Part.seed++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
        public Outsourced(int PartID, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
    }
}
