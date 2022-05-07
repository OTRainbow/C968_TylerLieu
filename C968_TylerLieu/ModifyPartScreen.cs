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
    public partial class ModifyPartScreen : Form
    {
        Part currentPart = MainScreen.currentPart;
        int currentPartIndex = MainScreen.currentPartIndex;
        public ModifyPartScreen()
        {
            InitializeComponent();
            // Pre-Populating Fields
            txtbx_id.Text = Convert.ToString(currentPart.PartID);
            txtbx_name.Text = currentPart.Name;
            txtbx_inventory.Text = Convert.ToString(currentPart.InStock);
            txtbx_cost.Text = Convert.ToString(currentPart.Price);
            txtbx_min.Text = Convert.ToString(currentPart.Min);
            txtbx_max.Text = Convert.ToString(currentPart.Max);
            if (currentPart is InHouse)
            {
                radio_inhouse.Checked = true;
                InHouse InHousePart = (InHouse)currentPart;
                txtbx_machineid.Text = Convert.ToString(InHousePart.MachineID);
            }
            if (currentPart is Outsourced)
            {
                radio_outsourced.Checked = true;
                Outsourced OutsourcedPart = (Outsourced)currentPart;
                txtbx_companyname.Text = OutsourcedPart.CompanyName;
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_inhouse.Checked == true)
            {
                lbl_machineid.Show();
                txtbx_machineid.Show();
                lbl_companyname.Hide();
                txtbx_companyname.Hide();
            }
            if (radio_outsourced.Checked == true)
            {
                lbl_machineid.Hide();
                txtbx_machineid.Hide();
                lbl_companyname.Show();
                txtbx_companyname.Show();
            }
            btn_save.Enabled = allowSave();
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

            if (radio_inhouse.Checked)
            {
                InHouse updatedInHouse = new InHouse(
                    Convert.ToInt32(txtbx_id.Text),
                    txtbx_name.Text,
                    Convert.ToDecimal(txtbx_cost.Text),
                    Convert.ToInt32(txtbx_inventory.Text),
                    Convert.ToInt32(txtbx_min.Text),
                    Convert.ToInt32(txtbx_max.Text),
                    Convert.ToInt32(txtbx_machineid.Text)
                    );
                Inventory.updatePart(currentPartIndex, updatedInHouse);
            }
            if (radio_outsourced.Checked)
            {
                Outsourced updatedOutsourced = new Outsourced(
                    Convert.ToInt32(txtbx_id.Text),
                    txtbx_name.Text,
                    Convert.ToDecimal(txtbx_cost.Text),
                    Convert.ToInt32(txtbx_inventory.Text),
                    Convert.ToInt32(txtbx_min.Text),
                    Convert.ToInt32(txtbx_max.Text),
                    txtbx_companyname.Text
                    );
                Inventory.updatePart(currentPartIndex, updatedOutsourced);
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool allowSave()
        {
            int result;
            if (radio_inhouse.Checked && (string.IsNullOrWhiteSpace(txtbx_machineid.Text) || !Int32.TryParse(txtbx_machineid.Text, out result)))
            {
                return false;
            }
            if (radio_outsourced.Checked && string.IsNullOrWhiteSpace(txtbx_companyname.Text))
            {
                return false;
            }

            return (
                !(string.IsNullOrWhiteSpace(txtbx_name.Text)) &&
                !(string.IsNullOrWhiteSpace(txtbx_inventory.Text) || !Int32.TryParse(txtbx_inventory.Text, out result)) &&
                !(string.IsNullOrWhiteSpace(txtbx_cost.Text) || !Decimal.TryParse(txtbx_cost.Text, out decimal res)) &&
                !(string.IsNullOrWhiteSpace(txtbx_max.Text) || !Int32.TryParse(txtbx_max.Text, out result)) &&
                !(string.IsNullOrWhiteSpace(txtbx_min.Text) || !Int32.TryParse(txtbx_min.Text, out result))
                );
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

        private void txtbx_machineid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_machineid.Text) || !Int32.TryParse(txtbx_machineid.Text, out int result))
            {
                txtbx_machineid.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_machineid.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }

        private void txtbx_companyname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbx_companyname.Text))
            {
                txtbx_companyname.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                txtbx_companyname.BackColor = System.Drawing.Color.White;
            }
            btn_save.Enabled = allowSave();
        }
    }
}
