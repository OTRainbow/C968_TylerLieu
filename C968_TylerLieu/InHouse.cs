using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_TylerLieu
{
    class InHouse : Part
    {
        public int MachineID { get; set; }
        public InHouse(string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
        {
            this.PartID = Part.seed++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.MachineID = MachineID;
        }
        public InHouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.MachineID = MachineID;
        }
    }
}
