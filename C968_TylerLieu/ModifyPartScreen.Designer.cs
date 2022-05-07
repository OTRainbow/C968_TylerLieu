
namespace C968_TylerLieu
{
    partial class ModifyPartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_machineid = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtbx_machineid = new System.Windows.Forms.TextBox();
            this.txtbx_min = new System.Windows.Forms.TextBox();
            this.txtbx_max = new System.Windows.Forms.TextBox();
            this.txtbx_cost = new System.Windows.Forms.TextBox();
            this.txtbx_inventory = new System.Windows.Forms.TextBox();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.radio_outsourced = new System.Windows.Forms.RadioButton();
            this.radio_inhouse = new System.Windows.Forms.RadioButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtbx_companyname = new System.Windows.Forms.TextBox();
            this.lbl_companyname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(116, 326);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 37;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(197, 326);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_machineid
            // 
            this.lbl_machineid.AutoSize = true;
            this.lbl_machineid.Location = new System.Drawing.Point(53, 233);
            this.lbl_machineid.Name = "lbl_machineid";
            this.lbl_machineid.Size = new System.Drawing.Size(62, 13);
            this.lbl_machineid.TabIndex = 35;
            this.lbl_machineid.Text = "Machine ID";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(58, 207);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(24, 13);
            this.lbl_min.TabIndex = 33;
            this.lbl_min.Text = "Min";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(154, 207);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(27, 13);
            this.lbl_max.TabIndex = 34;
            this.lbl_max.Text = "Max";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(19, 181);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(63, 13);
            this.lbl_cost.TabIndex = 32;
            this.lbl_cost.Text = "Price / Cost";
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Location = new System.Drawing.Point(31, 155);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(51, 13);
            this.lbl_inventory.TabIndex = 31;
            this.lbl_inventory.Text = "Inventory";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(47, 129);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 30;
            this.lbl_name.Text = "Name";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(64, 103);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 29;
            this.lbl_id.Text = "ID";
            // 
            // txtbx_machineid
            // 
            this.txtbx_machineid.Location = new System.Drawing.Point(121, 230);
            this.txtbx_machineid.Name = "txtbx_machineid";
            this.txtbx_machineid.Size = new System.Drawing.Size(100, 20);
            this.txtbx_machineid.TabIndex = 28;
            this.txtbx_machineid.TextChanged += new System.EventHandler(this.txtbx_machineid_TextChanged);
            // 
            // txtbx_min
            // 
            this.txtbx_min.Location = new System.Drawing.Point(88, 204);
            this.txtbx_min.Name = "txtbx_min";
            this.txtbx_min.Size = new System.Drawing.Size(60, 20);
            this.txtbx_min.TabIndex = 26;
            this.txtbx_min.TextChanged += new System.EventHandler(this.txtbx_min_TextChanged);
            // 
            // txtbx_max
            // 
            this.txtbx_max.Location = new System.Drawing.Point(183, 204);
            this.txtbx_max.Name = "txtbx_max";
            this.txtbx_max.Size = new System.Drawing.Size(60, 20);
            this.txtbx_max.TabIndex = 27;
            this.txtbx_max.TextChanged += new System.EventHandler(this.txtbx_max_TextChanged);
            // 
            // txtbx_cost
            // 
            this.txtbx_cost.Location = new System.Drawing.Point(88, 178);
            this.txtbx_cost.Name = "txtbx_cost";
            this.txtbx_cost.Size = new System.Drawing.Size(100, 20);
            this.txtbx_cost.TabIndex = 25;
            this.txtbx_cost.TextChanged += new System.EventHandler(this.txtbx_cost_TextChanged);
            // 
            // txtbx_inventory
            // 
            this.txtbx_inventory.Location = new System.Drawing.Point(88, 152);
            this.txtbx_inventory.Name = "txtbx_inventory";
            this.txtbx_inventory.Size = new System.Drawing.Size(100, 20);
            this.txtbx_inventory.TabIndex = 24;
            this.txtbx_inventory.TextChanged += new System.EventHandler(this.txtbx_inventory_TextChanged);
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(88, 126);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name.TabIndex = 23;
            this.txtbx_name.TextChanged += new System.EventHandler(this.txtbx_name_TextChanged);
            // 
            // txtbx_id
            // 
            this.txtbx_id.Enabled = false;
            this.txtbx_id.Location = new System.Drawing.Point(88, 100);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.ReadOnly = true;
            this.txtbx_id.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id.TabIndex = 22;
            // 
            // radio_outsourced
            // 
            this.radio_outsourced.AutoSize = true;
            this.radio_outsourced.Location = new System.Drawing.Point(141, 77);
            this.radio_outsourced.Name = "radio_outsourced";
            this.radio_outsourced.Size = new System.Drawing.Size(80, 17);
            this.radio_outsourced.TabIndex = 21;
            this.radio_outsourced.TabStop = true;
            this.radio_outsourced.Text = "Outsourced";
            this.radio_outsourced.UseVisualStyleBackColor = true;
            this.radio_outsourced.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio_inhouse
            // 
            this.radio_inhouse.AutoSize = true;
            this.radio_inhouse.Location = new System.Drawing.Point(67, 77);
            this.radio_inhouse.Name = "radio_inhouse";
            this.radio_inhouse.Size = new System.Drawing.Size(68, 17);
            this.radio_inhouse.TabIndex = 20;
            this.radio_inhouse.TabStop = true;
            this.radio_inhouse.Text = "In-House";
            this.radio_inhouse.UseVisualStyleBackColor = true;
            this.radio_inhouse.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(88, 20);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Modify Part";
            // 
            // txtbx_companyname
            // 
            this.txtbx_companyname.Location = new System.Drawing.Point(121, 230);
            this.txtbx_companyname.Name = "txtbx_companyname";
            this.txtbx_companyname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_companyname.TabIndex = 29;
            this.txtbx_companyname.TextChanged += new System.EventHandler(this.txtbx_companyname_TextChanged);
            // 
            // lbl_companyname
            // 
            this.lbl_companyname.AutoSize = true;
            this.lbl_companyname.Location = new System.Drawing.Point(33, 233);
            this.lbl_companyname.Name = "lbl_companyname";
            this.lbl_companyname.Size = new System.Drawing.Size(82, 13);
            this.lbl_companyname.TabIndex = 39;
            this.lbl_companyname.Text = "Company Name";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.lbl_companyname);
            this.Controls.Add(this.txtbx_companyname);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_machineid);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtbx_machineid);
            this.Controls.Add(this.txtbx_min);
            this.Controls.Add(this.txtbx_max);
            this.Controls.Add(this.txtbx_cost);
            this.Controls.Add(this.txtbx_inventory);
            this.Controls.Add(this.txtbx_name);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.radio_outsourced);
            this.Controls.Add(this.radio_inhouse);
            this.Controls.Add(this.lbl_title);
            this.Name = "ModifyPartScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_machineid;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbx_machineid;
        private System.Windows.Forms.TextBox txtbx_min;
        private System.Windows.Forms.TextBox txtbx_max;
        private System.Windows.Forms.TextBox txtbx_cost;
        private System.Windows.Forms.TextBox txtbx_inventory;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.RadioButton radio_outsourced;
        private System.Windows.Forms.RadioButton radio_inhouse;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtbx_companyname;
        private System.Windows.Forms.Label lbl_companyname;
    }
}