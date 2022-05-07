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
    public partial class AddProductScreen : Form
    {
        public Part currentPartAll;
        public Part currentPartAssociated;
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            txtbx_id.Text = Convert.ToString(Product.seed);
            dGV_parts_all.DataSource = Inventory.AllParts;
            dGV_parts_associated.DataSource = AssociatedParts;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbx_search.Text))
            {
                if (Int32.TryParse(txtbx_search.Text, out int PartID))
                {
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.PartID == PartID)
                        {
                            int PartIndex = Inventory.AllParts.IndexOf(part);
                            dGV_parts_all.Rows[PartIndex].Selected = true;
                            currentPartAll = part;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (Part part in Inventory.AllParts)
                    {
                        if (part.Name.ToUpper().Contains(txtbx_search.Text.ToUpper()))
                        {
                            int PartIndex = Inventory.AllParts.IndexOf(part);
                            dGV_parts_all.Rows[PartIndex].Selected = true;
                            currentPartAll = part;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!AssociatedParts.Contains(currentPartAll))
            {
                AssociatedParts.Add(currentPartAll);
            }
            else
            {
                MessageBox.Show($"{currentPartAll.Name} has already been added");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (AssociatedParts.Count != 0)
            {
                DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete {currentPartAssociated.Name}?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    AssociatedParts.Remove(currentPartAssociated);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbx_min.Text) > Convert.ToInt32(txtbx_max.Text))
            {
                MessageBox.Show("Min entry must be less than Max entry");
                return;
            }
            if (Convert.ToInt32(txtbx_inventory.Text) < Convert.ToInt32(txtbx_min.Text) || Convert.ToInt32(txtbx_inventory.Text) > Convert.ToInt32(txtbx_max.Text))
            {
                MessageBox.Show("Inventory count must be between the min and max count");
                return;
            }

            Inventory.addProduct(new Product(
                txtbx_name.Text,
                Convert.ToDecimal(txtbx_cost.Text),
                Convert.ToInt32(txtbx_inventory.Text),
                Convert.ToInt32(txtbx_min.Text),
                Convert.ToInt32(txtbx_max.Text),
                AssociatedParts
                ));

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool allowSave()
        {
            int result;
            return (
                !(string.IsNullOrWhiteSpace(txtbx_name.Text)) &&
                !(string.IsNullOrWhiteSpace(txtbx_inventory.Text) || !Int32.TryParse(txtbx_inventory.Text, out result)) &&
                !(string.IsNullOrWhiteSpace(txtbx_cost.Text) || !Decimal.TryParse(txtbx_cost.Text, out decimal res)) &&
                !(string.IsNullOrWhiteSpace(txtbx_max.Text) || !Int32.TryParse(txtbx_max.Text, out result)) &&
                !(string.IsNullOrWhiteSpace(txtbx_min.Text) || !Int32.TryParse(txtbx_min.Text, out result))
                );
        }

// Selection Changed Methods
        private void dGV_parts_all_SelectionChanged(object sender, EventArgs e)
        {
            if ((Inventory.AllParts.Count != 0))
            {
                currentPartAll = (Part)dGV_parts_all.CurrentRow.DataBoundItem;
            }
        }

        private void dGV_parts_associated_SelectionChanged(object sender, EventArgs e)
        {
            if ((AssociatedParts.Count != 0))
            {
                currentPartAssociated = (Part)dGV_parts_associated.CurrentRow.DataBoundItem;
            }
        }

// Text Changed Methods
        private void txtbx_name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_name.Text))
            {
                txtbx_name.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_name.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }

        private void txtbx_inventory_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_inventory.Text) || !Int32.TryParse(txtbx_inventory.Text, out int result))
            {
                txtbx_inventory.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_inventory.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }

        private void txtbx_cost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_cost.Text) || !Decimal.TryParse(txtbx_cost.Text, out decimal result))
            {
                txtbx_cost.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_cost.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }

        private void txtbx_min_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_min.Text) || !Int32.TryParse(txtbx_min.Text, out int result))
            {
                txtbx_min.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_min.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }

        private void txtbx_max_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_max.Text) || !Int32.TryParse(txtbx_max.Text, out int result))
            {
                txtbx_max.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_max.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }
    }
}
