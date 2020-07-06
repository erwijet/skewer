namespace SKU_Maker
{
    partial class frm_edit_xml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit_xml));
            this.lb_prop = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prod_name = new System.Windows.Forms.TextBox();
            this.lb_values = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_prop_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_prop_type = new System.Windows.Forms.ComboBox();
            this.tb_prod_comment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_prop_add = new System.Windows.Forms.Button();
            this.btn_prop_remove = new System.Windows.Forms.Button();
            this.tb_value_prettyname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_value_remove = new System.Windows.Forms.Button();
            this.btn_value_add = new System.Windows.Forms.Button();
            this.tb_value_code = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_cond_value = new System.Windows.Forms.TextBox();
            this.cb_cond_op = new System.Windows.Forms.ComboBox();
            this.cb_cond_prop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save_as = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_prop
            // 
            this.lb_prop.FormattingEnabled = true;
            this.lb_prop.Location = new System.Drawing.Point(8, 24);
            this.lb_prop.Name = "lb_prop";
            this.lb_prop.Size = new System.Drawing.Size(208, 264);
            this.lb_prop.TabIndex = 3;
            this.lb_prop.SelectedIndexChanged += new System.EventHandler(this.lb_prop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name:";
            // 
            // tb_prod_name
            // 
            this.tb_prod_name.Location = new System.Drawing.Point(94, 6);
            this.tb_prod_name.Name = "tb_prod_name";
            this.tb_prod_name.Size = new System.Drawing.Size(146, 20);
            this.tb_prod_name.TabIndex = 6;
            this.tb_prod_name.TextChanged += new System.EventHandler(this.tb_prod_name_TextChanged);
            this.tb_prod_name.Leave += new System.EventHandler(this.tb_prod_name_Leave);
            // 
            // lb_values
            // 
            this.lb_values.FormattingEnabled = true;
            this.lb_values.Location = new System.Drawing.Point(7, 24);
            this.lb_values.Name = "lb_values";
            this.lb_values.Size = new System.Drawing.Size(208, 264);
            this.lb_values.TabIndex = 7;
            this.lb_values.SelectedIndexChanged += new System.EventHandler(this.lb_values_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Property Name:";
            // 
            // tb_prop_name
            // 
            this.tb_prop_name.Enabled = false;
            this.tb_prop_name.Location = new System.Drawing.Point(90, 323);
            this.tb_prop_name.Name = "tb_prop_name";
            this.tb_prop_name.Size = new System.Drawing.Size(126, 20);
            this.tb_prop_name.TabIndex = 10;
            this.tb_prop_name.TextChanged += new System.EventHandler(this.tb_prop_name_TextChanged);
            this.tb_prop_name.Leave += new System.EventHandler(this.tb_prop_name_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Property Type:";
            // 
            // cb_prop_type
            // 
            this.cb_prop_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_prop_type.Enabled = false;
            this.cb_prop_type.FormattingEnabled = true;
            this.cb_prop_type.Items.AddRange(new object[] {
            "Mutable",
            "Conditional"});
            this.cb_prop_type.Location = new System.Drawing.Point(90, 349);
            this.cb_prop_type.Name = "cb_prop_type";
            this.cb_prop_type.Size = new System.Drawing.Size(126, 21);
            this.cb_prop_type.TabIndex = 12;
            this.cb_prop_type.SelectedIndexChanged += new System.EventHandler(this.cb_prop_type_SelectedIndexChanged);
            // 
            // tb_prod_comment
            // 
            this.tb_prod_comment.Location = new System.Drawing.Point(311, 6);
            this.tb_prod_comment.Name = "tb_prod_comment";
            this.tb_prod_comment.Size = new System.Drawing.Size(164, 20);
            this.tb_prod_comment.TabIndex = 14;
            this.tb_prod_comment.TextChanged += new System.EventHandler(this.tb_prod_comment_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comment:";
            // 
            // btn_prop_add
            // 
            this.btn_prop_add.Location = new System.Drawing.Point(8, 294);
            this.btn_prop_add.Name = "btn_prop_add";
            this.btn_prop_add.Size = new System.Drawing.Size(75, 23);
            this.btn_prop_add.TabIndex = 15;
            this.btn_prop_add.Text = "Add";
            this.btn_prop_add.UseVisualStyleBackColor = true;
            this.btn_prop_add.Click += new System.EventHandler(this.btn_prop_add_Click);
            // 
            // btn_prop_remove
            // 
            this.btn_prop_remove.Enabled = false;
            this.btn_prop_remove.Location = new System.Drawing.Point(141, 294);
            this.btn_prop_remove.Name = "btn_prop_remove";
            this.btn_prop_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_prop_remove.TabIndex = 16;
            this.btn_prop_remove.Text = "Remove";
            this.btn_prop_remove.UseVisualStyleBackColor = true;
            this.btn_prop_remove.Click += new System.EventHandler(this.btn_prop_remove_Click);
            // 
            // tb_value_prettyname
            // 
            this.tb_value_prettyname.Enabled = false;
            this.tb_value_prettyname.Location = new System.Drawing.Point(89, 326);
            this.tb_value_prettyname.Name = "tb_value_prettyname";
            this.tb_value_prettyname.Size = new System.Drawing.Size(126, 20);
            this.tb_value_prettyname.TabIndex = 18;
            this.tb_value_prettyname.TextChanged += new System.EventHandler(this.tb_value_prettyname_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pretty Name:";
            // 
            // btn_value_remove
            // 
            this.btn_value_remove.Enabled = false;
            this.btn_value_remove.Location = new System.Drawing.Point(140, 294);
            this.btn_value_remove.Name = "btn_value_remove";
            this.btn_value_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_value_remove.TabIndex = 20;
            this.btn_value_remove.Text = "Remove";
            this.btn_value_remove.UseVisualStyleBackColor = true;
            this.btn_value_remove.Click += new System.EventHandler(this.btn_value_remove_Click);
            // 
            // btn_value_add
            // 
            this.btn_value_add.Enabled = false;
            this.btn_value_add.Location = new System.Drawing.Point(7, 294);
            this.btn_value_add.Name = "btn_value_add";
            this.btn_value_add.Size = new System.Drawing.Size(75, 23);
            this.btn_value_add.TabIndex = 19;
            this.btn_value_add.Text = "Add";
            this.btn_value_add.UseVisualStyleBackColor = true;
            this.btn_value_add.Click += new System.EventHandler(this.btn_value_add_Click);
            // 
            // tb_value_code
            // 
            this.tb_value_code.Enabled = false;
            this.tb_value_code.Location = new System.Drawing.Point(89, 349);
            this.tb_value_code.Name = "tb_value_code";
            this.tb_value_code.Size = new System.Drawing.Size(126, 20);
            this.tb_value_code.TabIndex = 22;
            this.tb_value_code.TextChanged += new System.EventHandler(this.tb_value_code_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Value Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_prop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_prop_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_prop_type);
            this.groupBox1.Controls.Add(this.btn_prop_add);
            this.groupBox1.Controls.Add(this.btn_prop_remove);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 382);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lb_values);
            this.groupBox2.Controls.Add(this.tb_value_code);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_value_prettyname);
            this.groupBox2.Controls.Add(this.btn_value_remove);
            this.groupBox2.Controls.Add(this.btn_value_add);
            this.groupBox2.Location = new System.Drawing.Point(254, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 468);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Values";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_cond_value);
            this.groupBox3.Controls.Add(this.cb_cond_op);
            this.groupBox3.Controls.Add(this.cb_cond_prop);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 78);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condition";
            // 
            // tb_cond_value
            // 
            this.tb_cond_value.Enabled = false;
            this.tb_cond_value.Location = new System.Drawing.Point(66, 43);
            this.tb_cond_value.Name = "tb_cond_value";
            this.tb_cond_value.Size = new System.Drawing.Size(129, 20);
            this.tb_cond_value.TabIndex = 3;
            this.tb_cond_value.TextChanged += new System.EventHandler(this.tb_cond_value_TextChanged);
            // 
            // cb_cond_op
            // 
            this.cb_cond_op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cond_op.Enabled = false;
            this.cb_cond_op.FormattingEnabled = true;
            this.cb_cond_op.Items.AddRange(new object[] {
            "is",
            "isn\'t"});
            this.cb_cond_op.Location = new System.Drawing.Point(10, 43);
            this.cb_cond_op.Name = "cb_cond_op";
            this.cb_cond_op.Size = new System.Drawing.Size(50, 21);
            this.cb_cond_op.TabIndex = 2;
            this.cb_cond_op.SelectedIndexChanged += new System.EventHandler(this.cb_cond_op_SelectedIndexChanged);
            // 
            // cb_cond_prop
            // 
            this.cb_cond_prop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cond_prop.Enabled = false;
            this.cb_cond_prop.FormattingEnabled = true;
            this.cb_cond_prop.Location = new System.Drawing.Point(66, 17);
            this.cb_cond_prop.Name = "cb_cond_prop";
            this.cb_cond_prop.Size = new System.Drawing.Size(129, 21);
            this.cb_cond_prop.TabIndex = 1;
            this.cb_cond_prop.SelectedIndexChanged += new System.EventHandler(this.cb_cond_prop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "if property";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(15, 467);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save_as
            // 
            this.btn_save_as.Location = new System.Drawing.Point(173, 496);
            this.btn_save_as.Name = "btn_save_as";
            this.btn_save_as.Size = new System.Drawing.Size(75, 23);
            this.btn_save_as.TabIndex = 26;
            this.btn_save_as.Text = "Save As";
            this.btn_save_as.UseVisualStyleBackColor = true;
            this.btn_save_as.Click += new System.EventHandler(this.btn_save_as_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(173, 467);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(15, 496);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 28;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // frm_edit_xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(492, 534);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_save_as);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_prod_comment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_prod_name);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_edit_xml";
            this.Text = "Skewer | Edit XML";
            this.Load += new System.EventHandler(this.frm_edit_xml_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_prop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prod_name;
        private System.Windows.Forms.ListBox lb_values;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_prop_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_prop_type;
        private System.Windows.Forms.TextBox tb_prod_comment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_prop_add;
        private System.Windows.Forms.Button btn_prop_remove;
        private System.Windows.Forms.TextBox tb_value_prettyname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_value_remove;
        private System.Windows.Forms.Button btn_value_add;
        private System.Windows.Forms.TextBox tb_value_code;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_cond_value;
        private System.Windows.Forms.ComboBox cb_cond_op;
        private System.Windows.Forms.ComboBox cb_cond_prop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save_as;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_help;
    }
}