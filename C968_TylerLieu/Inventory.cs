using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968_TylerLieu
{
    class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }
        public void addProduct(Product product)
        {

        }
        public bool removeProduct(int ProductID)
        {
            return true;
        }
        public Product lookupProduct(int ProductID)
        {
            return null;
        }
        public void updateProduct(int ProductID, Product product)
        {

        }
        public void addPart(Part part)
        {

        }
        public bool deletePart(Part part)
        {
            return true;
        }
        public Part lookupPart(int PartID)
        {
            return null;
        }
        public void updatePart(int PartID, Part part)
        {

        }
    }
}
