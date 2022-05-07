using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace C968_TylerLieu
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initial Parts
            Inventory.addPart(new InHouse("Wheel", 12.11M, 15, 5, 25, 123456));
            Inventory.addPart(new Outsourced("Pedal", 8.22M, 11, 5, 25, "SomeCompany"));
            Inventory.addPart(new InHouse("Chain", 8.33M, 12, 5, 25, 654321));
            Inventory.addPart(new Outsourced("Seat", 4.55M, 8, 2, 15, "OtherCompany"));
            // Initial Products
            Inventory.addProduct(new Product("Red Bicycle", 11.44M, 15, 1, 25, new BindingList<Part>()));
            Inventory.addProduct(new Product("Yellow Bicycle", 9.66M, 19, 1, 20, new BindingList<Part>()));
            Inventory.addProduct(new Product("Blue Bicycle", 12.77M, 5, 1, 25, new BindingList<Part>()));
            // Run Application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
