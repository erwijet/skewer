namespace SKU_Maker
{
    partial class frm_main
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_csv = new System.Windows.Forms.RadioButton();
            this.rb_table = new System.Windows.Forms.RadioButton();
            this.btn_generate = new System.Windows.Forms.Button();
            this.gb_schema_controls = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_static_component_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_static_component = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_prop_add = new System.Windows.Forms.Button();
            this.lb_properties = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flp_sku = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sku_schema_load = new System.Windows.Forms.Button();
            this.btn_sku_schema_save = new System.Windows.Forms.Button();
            this.btn_prod_modify = new System.Windows.Forms.Button();
            this.btn_prod_create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.btn_prod_remove = new System.Windows.Forms.Button();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.gb_schema_controls.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_csv);
            this.groupBox6.Controls.Add(this.rb_table);
            this.groupBox6.Controls.Add(this.btn_generate);
            this.groupBox6.Location = new System.Drawing.Point(413, 642);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(706, 92);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Export As";
            // 
            // rb_csv
            // 
            this.rb_csv.AutoSize = true;
            this.rb_csv.Location = new System.Drawing.Point(124, 44);
            this.rb_csv.Name = "rb_csv";
            this.rb_csv.Size = new System.Drawing.Size(86, 29);
            this.rb_csv.TabIndex = 11;
            this.rb_csv.Text = "CSV";
            this.rb_csv.UseVisualStyleBackColor = true;
            // 
            // rb_table
            // 
            this.rb_table.AutoSize = true;
            this.rb_table.Checked = true;
            this.rb_table.Location = new System.Drawing.Point(21, 44);
            this.rb_table.Name = "rb_table";
            this.rb_table.Size = new System.Drawing.Size(97, 29);
            this.rb_table.TabIndex = 10;
            this.rb_table.TabStop = true;
            this.rb_table.Text = "Table";
            this.rb_table.UseVisualStyleBackColor = true;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(490, 36);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(6);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(204, 44);
            this.btn_generate.TabIndex = 9;
            this.btn_generate.Text = "Export";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // gb_schema_controls
            // 
            this.gb_schema_controls.Controls.Add(this.btn_delete);
            this.gb_schema_controls.Controls.Add(this.btn_right);
            this.gb_schema_controls.Controls.Add(this.btn_left);
            this.gb_schema_controls.Controls.Add(this.groupBox5);
            this.gb_schema_controls.Controls.Add(this.groupBox4);
            this.gb_schema_controls.Controls.Add(this.groupBox3);
            this.gb_schema_controls.Controls.Add(this.btn_sku_schema_load);
            this.gb_schema_controls.Controls.Add(this.btn_sku_schema_save);
            this.gb_schema_controls.Enabled = false;
            this.gb_schema_controls.Location = new System.Drawing.Point(407, 15);
            this.gb_schema_controls.Margin = new System.Windows.Forms.Padding(6);
            this.gb_schema_controls.Name = "gb_schema_controls";
            this.gb_schema_controls.Padding = new System.Windows.Forms.Padding(6);
            this.gb_schema_controls.Size = new System.Drawing.Size(706, 615);
            this.gb_schema_controls.TabIndex = 8;
            this.gb_schema_controls.TabStop = false;
            this.gb_schema_controls.Text = "SKU Schema";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(522, 259);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(172, 44);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(522, 204);
            this.btn_right.Margin = new System.Windows.Forms.Padding(6);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(172, 44);
            this.btn_right.TabIndex = 8;
            this.btn_right.Text = "Move Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(336, 204);
            this.btn_left.Margin = new System.Windows.Forms.Padding(6);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(172, 44);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "Move Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_static_component_add);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tb_static_component);
            this.groupBox5.Location = new System.Drawing.Point(336, 369);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(358, 181);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Static Component";
            // 
            // btn_static_component_add
            // 
            this.btn_static_component_add.Location = new System.Drawing.Point(196, 123);
            this.btn_static_component_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_static_component_add.Name = "btn_static_component_add";
            this.btn_static_component_add.Size = new System.Drawing.Size(150, 44);
            this.btn_static_component_add.TabIndex = 2;
            this.btn_static_component_add.Text = "Add";
            this.btn_static_component_add.UseVisualStyleBackColor = true;
            this.btn_static_component_add.Click += new System.EventHandler(this.btn_static_component_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // tb_static_component
            // 
            this.tb_static_component.Location = new System.Drawing.Point(80, 37);
            this.tb_static_component.Margin = new System.Windows.Forms.Padding(6);
            this.tb_static_component.Name = "tb_static_component";
            this.tb_static_component.Size = new System.Drawing.Size(262, 31);
            this.tb_static_component.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_prop_add);
            this.groupBox4.Controls.Add(this.lb_properties);
            this.groupBox4.Location = new System.Drawing.Point(12, 204);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(310, 402);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Properties";
            // 
            // btn_prop_add
            // 
            this.btn_prop_add.Location = new System.Drawing.Point(151, 346);
            this.btn_prop_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prop_add.Name = "btn_prop_add";
            this.btn_prop_add.Size = new System.Drawing.Size(150, 44);
            this.btn_prop_add.TabIndex = 11;
            this.btn_prop_add.Text = "Add";
            this.btn_prop_add.UseVisualStyleBackColor = true;
            this.btn_prop_add.Click += new System.EventHandler(this.btn_prop_add_Click);
            // 
            // lb_properties
            // 
            this.lb_properties.FormattingEnabled = true;
            this.lb_properties.ItemHeight = 25;
            this.lb_properties.Location = new System.Drawing.Point(9, 45);
            this.lb_properties.Name = "lb_properties";
            this.lb_properties.Size = new System.Drawing.Size(292, 279);
            this.lb_properties.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flp_sku);
            this.groupBox3.Location = new System.Drawing.Point(14, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(680, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SKU";
            // 
            // flp_sku
            // 
            this.flp_sku.AutoScroll = true;
            this.flp_sku.BackColor = System.Drawing.Color.White;
            this.flp_sku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_sku.Location = new System.Drawing.Point(6, 30);
            this.flp_sku.Margin = new System.Windows.Forms.Padding(6);
            this.flp_sku.Name = "flp_sku";
            this.flp_sku.Size = new System.Drawing.Size(668, 118);
            this.flp_sku.TabIndex = 0;
            this.flp_sku.WrapContents = false;
            // 
            // btn_sku_schema_load
            // 
            this.btn_sku_schema_load.Location = new System.Drawing.Point(544, 561);
            this.btn_sku_schema_load.Margin = new System.Windows.Forms.Padding(6);
            this.btn_sku_schema_load.Name = "btn_sku_schema_load";
            this.btn_sku_schema_load.Size = new System.Drawing.Size(150, 44);
            this.btn_sku_schema_load.TabIndex = 1;
            this.btn_sku_schema_load.Text = "Load";
            this.btn_sku_schema_load.UseVisualStyleBackColor = true;
            this.btn_sku_schema_load.Click += new System.EventHandler(this.btn_sku_schema_load_Click);
            // 
            // btn_sku_schema_save
            // 
            this.btn_sku_schema_save.Location = new System.Drawing.Point(336, 561);
            this.btn_sku_schema_save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_sku_schema_save.Name = "btn_sku_schema_save";
            this.btn_sku_schema_save.Size = new System.Drawing.Size(150, 44);
            this.btn_sku_schema_save.TabIndex = 0;
            this.btn_sku_schema_save.Text = "Save";
            this.btn_sku_schema_save.UseVisualStyleBackColor = true;
            this.btn_sku_schema_save.Click += new System.EventHandler(this.btn_sku_schema_save_Click);
            // 
            // btn_prod_modify
            // 
            this.btn_prod_modify.Location = new System.Drawing.Point(199, 690);
            this.btn_prod_modify.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prod_modify.Name = "btn_prod_modify";
            this.btn_prod_modify.Size = new System.Drawing.Size(196, 44);
            this.btn_prod_modify.TabIndex = 7;
            this.btn_prod_modify.Text = "Open Product";
            this.btn_prod_modify.UseVisualStyleBackColor = true;
            this.btn_prod_modify.Click += new System.EventHandler(this.btn_prod_modify_Click);
            // 
            // btn_prod_create
            // 
            this.btn_prod_create.Location = new System.Drawing.Point(15, 690);
            this.btn_prod_create.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prod_create.Name = "btn_prod_create";
            this.btn_prod_create.Size = new System.Drawing.Size(184, 44);
            this.btn_prod_create.TabIndex = 6;
            this.btn_prod_create.Text = "Create Product";
            this.btn_prod_create.UseVisualStyleBackColor = true;
            this.btn_prod_create.Click += new System.EventHandler(this.btn_prod_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_products);
            this.groupBox1.Controls.Add(this.btn_prod_remove);
            this.groupBox1.Controls.Add(this.btn_prod_add);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(380, 606);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.ItemHeight = 25;
            this.lb_products.Location = new System.Drawing.Point(12, 33);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(356, 479);
            this.lb_products.TabIndex = 6;
            this.lb_products.SelectedIndexChanged += new System.EventHandler(this.lb_products_SelectedIndexChanged);
            // 
            // btn_prod_remove
            // 
            this.btn_prod_remove.Enabled = false;
            this.btn_prod_remove.Location = new System.Drawing.Point(218, 546);
            this.btn_prod_remove.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prod_remove.Name = "btn_prod_remove";
            this.btn_prod_remove.Size = new System.Drawing.Size(150, 44);
            this.btn_prod_remove.TabIndex = 5;
            this.btn_prod_remove.Text = "Remove";
            this.btn_prod_remove.UseVisualStyleBackColor = true;
            this.btn_prod_remove.Click += new System.EventHandler(this.btn_prod_remove_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.Location = new System.Drawing.Point(12, 546);
            this.btn_prod_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(150, 44);
            this.btn_prod_add.TabIndex = 4;
            this.btn_prod_add.Text = "Add";
            this.btn_prod_add.UseVisualStyleBackColor = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 753);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gb_schema_controls);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_prod_modify);
            this.Controls.Add(this.btn_prod_create);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_main";
            this.Text = "Skewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gb_schema_controls.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prod_add;
        private System.Windows.Forms.Button btn_prod_modify;
        private System.Windows.Forms.Button btn_prod_create;
        private System.Windows.Forms.Button btn_prod_remove;
        private System.Windows.Forms.GroupBox gb_schema_controls;
        private System.Windows.Forms.Button btn_sku_schema_load;
        private System.Windows.Forms.Button btn_sku_schema_save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flp_sku;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_static_component_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_static_component;
        private System.Windows.Forms.Button btn_prop_add;
        private System.Windows.Forms.ListBox lb_properties;
        private System.Windows.Forms.ListBox lb_products;
        private System.Windows.Forms.RadioButton rb_csv;
        private System.Windows.Forms.RadioButton rb_table;
    }
}

