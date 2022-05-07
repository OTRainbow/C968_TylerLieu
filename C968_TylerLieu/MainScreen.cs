using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_TylerLieu
{
    public partial class MainScreen : Form
    {
        public static Part currentPart;
        public static int currentPartIndex;
        public static Product currentProduct;
        public static int currentProductIndex;
        public MainScreen()
        {
            InitializeComponent();
            dGV_parts.DataSource = Inventory.AllParts;
            dGV_products.DataSource = Inventory.Products;
        }

        private void btn_parts_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_parts_search.Text))
            {
                if (Int32.TryParse(txtbx_parts_search.Text, out int PartID))
                {
                    foreach(Part part in Inventory.AllParts)
                    {
                        if(part.PartID == PartID)
                        {
                            int PartIndex = Inventory.AllParts.IndexOf(part);
                            dGV_parts.Rows[PartIndex].Selected = true;
                            currentPart = part;
                            break;
                        }
                    }
                    
                }
                else
                {
                    foreach(Part part in Inventory.AllParts)
                    {
                        if (part.Name.ToUpper().Contains(txtbx_parts_search.Text.ToUpper()))
                        {
                            int PartIndex = Inventory.AllParts.IndexOf(part);
                            dGV_parts.Rows[PartIndex].Selected = true;
                            currentPart = part;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_parts_add_Click(object sender, EventArgs e)
        {
            AddPartScreen AddPartScreen = new AddPartScreen();
            AddPartScreen.ShowDialog();
        }

        private void btn_parts_modify_Click(object sender, EventArgs e)
        {
            if(Inventory.AllParts.Count != 0)
            {
                ModifyPartScreen ModifyPartScreen = new ModifyPartScreen();
                ModifyPartScreen.ShowDialog();
                dGV_parts.Rows[currentPartIndex].Selected = false;
                dGV_parts.Rows[currentPartIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("There are no parts to modify.");
            }
        }

        private void btn_parts_delete_Click(object sender, EventArgs e)
        {
            if (Inventory.AllParts.Count != 0)
            {
                DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete {currentPart.Name}?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Inventory.deletePart(currentPart);
                }
            }
        }

        private void btn_products_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_products_search.Text))
            {
                if (Int32.TryParse(txtbx_products_search.Text, out int ProductID))
                {
                    foreach (Product product in Inventory.Products)
                    {
                        if (product.ProductID == ProductID)
                        {
                            int ProductIndex = Inventory.Products.IndexOf(product);
                            dGV_products.Rows[ProductIndex].Selected = true;
                            currentProduct = product;
                            break;
                        }
                    }

                }
                else
                {
                    foreach (Product product in Inventory.Products)
                    {
                        if (product.Name.ToUpper().Contains(txtbx_products_search.Text.ToUpper()))
                        {
                            int ProductIndex = Inventory.Products.IndexOf(product);
                            dGV_products.Rows[ProductIndex].Selected = true;
                            currentProduct = product;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_products_add_Click(object sender, EventArgs e)
        {
            AddProductScreen AddProductScreen = new AddProductScreen();
            AddProductScreen.ShowDialog();
        }

        private void btn_products_modify_Click(object sender, EventArgs e)
        {
            if(Inventory.Products.Count() != 0)
            {
                ModifyProductScreen ModifyProductScreen = new ModifyProductScreen();
                ModifyProductScreen.ShowDialog();
                dGV_products.Rows[currentProductIndex].Selected = false;
                dGV_products.Rows[currentProductIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("There are no products to modify.");
            }
        }

        private void btn_products_delete_Click(object sender, EventArgs e)
        {
            if (Inventory.Products.Count != 0)
            {
                if(currentProduct.AssociatedParts.Count() == 0)
                {
                    DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete {currentProduct.Name}?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        int productIndex = Inventory.Products.IndexOf(currentProduct);
                        Inventory.removeProduct(productIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Must delete all associated parts before deleting a product");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dGV_parts_SelectionChanged(object sender, EventArgs e)
        {
            if ((Inventory.AllParts.Count != 0))
            {
                currentPart = (Part)dGV_parts.CurrentRow.DataBoundItem;
                currentPartIndex = Inventory.AllParts.IndexOf(currentPart);
            }
        }

        private void dGV_products_SelectionChanged(object sender, EventArgs e)
        {
            if ((Inventory.Products.Count != 0))
            {
                currentProduct = (Product)dGV_products.CurrentRow.DataBoundItem;
                currentProductIndex = Inventory.Products.IndexOf(currentProduct);
            }
        }
    }
}
