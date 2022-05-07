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
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int ProductIndex)
        {
            if (Products.Remove(Products[ProductIndex]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Product lookupProduct(int ProductIndex)
        {
            return Products[ProductIndex];
        }
        public static void updateProduct(int ProductIndex, Product product)
        {
            Products[ProductIndex] = product;
        }
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public static bool deletePart(Part part)
        {
            if (AllParts.Remove(part))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Part lookupPart(int PartIndex)
        {
            return AllParts[PartIndex];
        }
        public static void updatePart(int PartIndex, Part part)
        {
            AllParts[PartIndex] = part;
        }
    }
}
