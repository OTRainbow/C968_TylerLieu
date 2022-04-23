using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968_TylerLieu
{
    class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public void addAssociatedPart(Part part)
        {

        }
        public bool removeAssociatedPart(int PartID)
        {
            return true;
        }
        public Part lookupAssociatedPart(int PartID)
        {
            return null;
        }
    }
}
