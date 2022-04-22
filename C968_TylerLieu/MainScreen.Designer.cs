
namespace C968_TylerLieu
{
    partial class MainScreen
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.dGV_parts = new System.Windows.Forms.DataGridView();
            this.dGV_products = new System.Windows.Forms.DataGridView();
            this.lbl_parts = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.txtbx_parts_search = new System.Windows.Forms.TextBox();
            this.txtbx_products_search = new System.Windows.Forms.TextBox();
            this.btn_parts_search = new System.Windows.Forms.Button();
            this.btn_products_search = new System.Windows.Forms.Button();
            this.btn_parts_delete = new System.Windows.Forms.Button();
            this.btn_parts_modify = new System.Windows.Forms.Button();
            this.btn_parts_add = new System.Windows.Forms.Button();
            this.btn_products_add = new System.Windows.Forms.Button();
            this.btn_products_modify = new System.Windows.Forms.Button();
            this.btn_products_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_products)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(153, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Inventory Management System";
            // 
            // dGV_parts
            // 
            this.dGV_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_parts.Location = new System.Drawing.Point(15, 77);
            this.dGV_parts.Name = "dGV_parts";
            this.dGV_parts.Size = new System.Drawing.Size(360, 240);
            this.dGV_parts.TabIndex = 1;
            // 
            // dGV_products
            // 
            this.dGV_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_products.Location = new System.Drawing.Point(428, 77);
            this.dGV_products.Name = "dGV_products";
            this.dGV_products.Size = new System.Drawing.Size(360, 240);
            this.dGV_products.TabIndex = 2;
            // 
            // lbl_parts
            // 
            this.lbl_parts.AutoSize = true;
            this.lbl_parts.Location = new System.Drawing.Point(12, 61);
            this.lbl_parts.Name = "lbl_parts";
            this.lbl_parts.Size = new System.Drawing.Size(31, 13);
            this.lbl_parts.TabIndex = 3;
            this.lbl_parts.Text = "Parts";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Location = new System.Drawing.Point(428, 61);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(49, 13);
            this.lbl_products.TabIndex = 4;
            this.lbl_products.Text = "Products";
            // 
            // txtbx_parts_search
            // 
            this.txtbx_parts_search.Location = new System.Drawing.Point(275, 51);
            this.txtbx_parts_search.Name = "txtbx_parts_search";
            this.txtbx_parts_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_parts_search.TabIndex = 5;
            // 
            // txtbx_products_search
            // 
            this.txtbx_products_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtbx_products_search.Location = new System.Drawing.Point(688, 51);
            this.txtbx_products_search.Name = "txtbx_products_search";
            this.txtbx_products_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_products_search.TabIndex = 6;
            // 
            // btn_parts_search
            // 
            this.btn_parts_search.Location = new System.Drawing.Point(194, 48);
            this.btn_parts_search.Name = "btn_parts_search";
            this.btn_parts_search.Size = new System.Drawing.Size(75, 25);
            this.btn_parts_search.TabIndex = 7;
            this.btn_parts_search.Text = "Search";
            this.btn_parts_search.UseVisualStyleBackColor = true;
            // 
            // btn_products_search
            // 
            this.btn_products_search.Location = new System.Drawing.Point(607, 48);
            this.btn_products_search.Name = "btn_products_search";
            this.btn_products_search.Size = new System.Drawing.Size(75, 25);
            this.btn_products_search.TabIndex = 8;
            this.btn_products_search.Text = "Search";
            this.btn_products_search.UseVisualStyleBackColor = true;
            // 
            // btn_parts_delete
            // 
            this.btn_parts_delete.Location = new System.Drawing.Point(300, 323);
            this.btn_parts_delete.Name = "btn_parts_delete";
            this.btn_parts_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_delete.TabIndex = 9;
            this.btn_parts_delete.Text = "Delete";
            this.btn_parts_delete.UseVisualStyleBackColor = true;
            // 
            // btn_parts_modify
            // 
            this.btn_parts_modify.Location = new System.Drawing.Point(219, 323);
            this.btn_parts_modify.Name = "btn_parts_modify";
            this.btn_parts_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_modify.TabIndex = 10;
            this.btn_parts_modify.Text = "Modify";
            this.btn_parts_modify.UseVisualStyleBackColor = true;
            // 
            // btn_parts_add
            // 
            this.btn_parts_add.Location = new System.Drawing.Point(138, 323);
            this.btn_parts_add.Name = "btn_parts_add";
            this.btn_parts_add.Size = new System.Drawing.Size(75, 23);
            this.btn_parts_add.TabIndex = 11;
            this.btn_parts_add.Text = "Add";
            this.btn_parts_add.UseVisualStyleBackColor = true;
            // 
            // btn_products_add
            // 
            this.btn_products_add.Location = new System.Drawing.Point(551, 323);
            this.btn_products_add.Name = "btn_products_add";
            this.btn_products_add.Size = new System.Drawing.Size(75, 23);
            this.btn_products_add.TabIndex = 14;
            this.btn_products_add.Text = "Add";
            this.btn_products_add.UseVisualStyleBackColor = true;
            // 
            // btn_products_modify
            // 
            this.btn_products_modify.Location = new System.Drawing.Point(632, 323);
            this.btn_products_modify.Name = "btn_products_modify";
            this.btn_products_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_products_modify.TabIndex = 13;
            this.btn_products_modify.Text = "Modify";
            this.btn_products_modify.UseVisualStyleBackColor = true;
            // 
            // btn_products_delete
            // 
            this.btn_products_delete.Location = new System.Drawing.Point(713, 323);
            this.btn_products_delete.Name = "btn_products_delete";
            this.btn_products_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_products_delete.TabIndex = 12;
            this.btn_products_delete.Text = "Delete";
            this.btn_products_delete.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_products_add);
            this.Controls.Add(this.btn_products_modify);
            this.Controls.Add(this.btn_products_delete);
            this.Controls.Add(this.btn_parts_add);
            this.Controls.Add(this.btn_parts_modify);
            this.Controls.Add(this.btn_parts_delete);
            this.Controls.Add(this.btn_products_search);
            this.Controls.Add(this.btn_parts_search);
            this.Controls.Add(this.txtbx_products_search);
            this.Controls.Add(this.txtbx_parts_search);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_parts);
            this.Controls.Add(this.dGV_products);
            this.Controls.Add(this.dGV_parts);
            this.Controls.Add(this.lbl_title);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_parts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dGV_parts;
        private System.Windows.Forms.DataGridView dGV_products;
        private System.Windows.Forms.Label lbl_parts;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.TextBox txtbx_parts_search;
        private System.Windows.Forms.TextBox txtbx_products_search;
        private System.Windows.Forms.Button btn_parts_search;
        private System.Windows.Forms.Button btn_products_search;
        private System.Windows.Forms.Button btn_parts_delete;
        private System.Windows.Forms.Button btn_parts_modify;
        private System.Windows.Forms.Button btn_parts_add;
        private System.Windows.Forms.Button btn_products_add;
        private System.Windows.Forms.Button btn_products_modify;
        private System.Windows.Forms.Button btn_products_delete;
        private System.Windows.Forms.Button btn_exit;
    }
}

