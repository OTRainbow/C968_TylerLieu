using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968_TylerLieu
{
    public class Product
    {
        public static int seed = 0;
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int AssociatedPartIndex)
        {
            if (AssociatedParts.Remove(AssociatedParts[AssociatedPartIndex]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Part lookupAssociatedPart(int AssociatedPartIndex)
        {
            return AssociatedParts[AssociatedPartIndex];
        }
        public Product(string Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> AssociatedParts)
        {
            this.ProductID = Product.seed++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.AssociatedParts = AssociatedParts;
        }
        public Product(int ProductID, string Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> AssociatedParts)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.AssociatedParts = AssociatedParts;
        }
    }
}
