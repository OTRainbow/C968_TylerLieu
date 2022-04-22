
namespace C968_TylerLieu
{
    partial class AddProductScreen
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtbx_min = new System.Windows.Forms.TextBox();
            this.txtbx_max = new System.Windows.Forms.TextBox();
            this.txtbx_cost = new System.Windows.Forms.TextBox();
            this.txtbx_inventory = new System.Windows.Forms.TextBox();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.dGV_parts_all = new System.Windows.Forms.DataGridView();
            this.dGV_parts_associated = new System.Windows.Forms.DataGridView();
            this.lbl_dGVtop = new System.Windows.Forms.Label();
            this.lbl_dGVbottom = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtbx_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts_associated)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(632, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(713, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(66, 13);
            this.lbl_title.TabIndex = 40;
            this.lbl_title.Text = "Add Product";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(174, 239);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(24, 13);
            this.lbl_min.TabIndex = 52;
            this.lbl_min.Text = "Min";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(74, 239);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(27, 13);
            this.lbl_max.TabIndex = 51;
            this.lbl_max.Text = "Max";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(38, 213);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(63, 13);
            this.lbl_cost.TabIndex = 50;
            this.lbl_cost.Text = "Price / Cost";
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Location = new System.Drawing.Point(50, 187);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(51, 13);
            this.lbl_inventory.TabIndex = 49;
            this.lbl_inventory.Text = "Inventory";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(66, 161);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 48;
            this.lbl_name.Text = "Name";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(83, 135);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 47;
            this.lbl_id.Text = "ID";
            // 
            // txtbx_min
            // 
            this.txtbx_min.Location = new System.Drawing.Point(204, 236);
            this.txtbx_min.Name = "txtbx_min";
            this.txtbx_min.Size = new System.Drawing.Size(60, 20);
            this.txtbx_min.TabIndex = 46;
            // 
            // txtbx_max
            // 
            this.txtbx_max.Location = new System.Drawing.Point(107, 236);
            this.txtbx_max.Name = "txtbx_max";
            this.txtbx_max.Size = new System.Drawing.Size(60, 20);
            this.txtbx_max.TabIndex = 45;
            // 
            // txtbx_cost
            // 
            this.txtbx_cost.Location = new System.Drawing.Point(107, 210);
            this.txtbx_cost.Name = "txtbx_cost";
            this.txtbx_cost.Size = new System.Drawing.Size(100, 20);
            this.txtbx_cost.TabIndex = 44;
            // 
            // txtbx_inventory
            // 
            this.txtbx_inventory.Location = new System.Drawing.Point(107, 184);
            this.txtbx_inventory.Name = "txtbx_inventory";
            this.txtbx_inventory.Size = new System.Drawing.Size(100, 20);
            this.txtbx_inventory.TabIndex = 43;
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(107, 158);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name.TabIndex = 42;
            // 
            // txtbx_id
            // 
            this.txtbx_id.Location = new System.Drawing.Point(107, 132);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.ReadOnly = true;
            this.txtbx_id.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id.TabIndex = 41;
            // 
            // dGV_parts_all
            // 
            this.dGV_parts_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_parts_all.Location = new System.Drawing.Point(385, 72);
            this.dGV_parts_all.Name = "dGV_parts_all";
            this.dGV_parts_all.Size = new System.Drawing.Size(322, 128);
            this.dGV_parts_all.TabIndex = 53;
            // 
            // dGV_parts_associated
            // 
            this.dGV_parts_associated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_parts_associated.Location = new System.Drawing.Point(385, 247);
            this.dGV_parts_associated.Name = "dGV_parts_associated";
            this.dGV_parts_associated.Size = new System.Drawing.Size(322, 124);
            this.dGV_parts_associated.TabIndex = 54;
            // 
            // lbl_dGVtop
            // 
            this.lbl_dGVtop.AutoSize = true;
            this.lbl_dGVtop.Location = new System.Drawing.Point(385, 53);
            this.lbl_dGVtop.Name = "lbl_dGVtop";
            this.lbl_dGVtop.Size = new System.Drawing.Size(96, 13);
            this.lbl_dGVtop.TabIndex = 55;
            this.lbl_dGVtop.Text = "All Candidate Parts";
            // 
            // lbl_dGVbottom
            // 
            this.lbl_dGVbottom.AutoSize = true;
            this.lbl_dGVbottom.Location = new System.Drawing.Point(382, 231);
            this.lbl_dGVbottom.Name = "lbl_dGVbottom";
            this.lbl_dGVbottom.Size = new System.Drawing.Size(167, 13);
            this.lbl_dGVbottom.TabIndex = 56;
            this.lbl_dGVbottom.Text = "Parts Associated with this Product";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(632, 203);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 57;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(632, 377);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 58;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // txtbx_search
            // 
            this.txtbx_search.Location = new System.Drawing.Point(606, 45);
            this.txtbx_search.Name = "txtbx_search";
            this.txtbx_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_search.TabIndex = 59;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(525, 43);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 60;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbx_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_dGVbottom);
            this.Controls.Add(this.lbl_dGVtop);
            this.Controls.Add(this.dGV_parts_associated);
            this.Controls.Add(this.dGV_parts_all);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtbx_min);
            this.Controls.Add(this.txtbx_max);
            this.Controls.Add(this.txtbx_cost);
            this.Controls.Add(this.txtbx_inventory);
            this.Controls.Add(this.txtbx_name);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Name = "AddProductScreen";
            this.Text = "AddProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts_associated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txtbx_min;
        private System.Windows.Forms.TextBox txtbx_max;
        private System.Windows.Forms.TextBox txtbx_cost;
        private System.Windows.Forms.TextBox txtbx_inventory;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.DataGridView dGV_parts_all;
        private System.Windows.Forms.DataGridView dGV_parts_associated;
        private System.Windows.Forms.Label lbl_dGVtop;
        private System.Windows.Forms.Label lbl_dGVbottom;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txtbx_search;
        private System.Windows.Forms.Button btn_search;
    }
}