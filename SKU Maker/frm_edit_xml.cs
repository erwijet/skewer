using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SKU_Maker
{
    public partial class frm_edit_xml : Form
    {
        public string filepath { get; set; }
        public Product product { get; set; }

        public frm_edit_xml(Product product, string filepath)
        {
            InitializeComponent();

            this.filepath = filepath;
            this.product = product;

            foreach (ProductProperty prop in product.Properties)
            {
                lb_prop.Items.Add(prop.Title);
            }

            tb_prod_name.Text = product.Name;
            tb_prod_comment.Text = product.Comment;
        }

        private void frm_edit_xml_Load(object sender, EventArgs e)
        {
            cb_cond_op.SelectedIndex = 0;
        }

        private void lb_prop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_value_remove.Enabled = false;
            tb_value_prettyname.Enabled = false;
            tb_value_code.Enabled = false;
            tb_cond_value.Enabled = false;
            cb_cond_op.Enabled = false;
            cb_cond_prop.Enabled = false;

            bool enabled = lb_prop.SelectedIndex >= 0;
            btn_prop_remove.Enabled = enabled;
            cb_prop_type.Enabled = enabled;
            tb_prop_name.Enabled = enabled;
            btn_value_add.Enabled = enabled;

            if (enabled)
            {
                cb_prop_type.SelectedIndex = product.Properties.ElementAt(lb_prop.SelectedIndex).Conditional ? 1 : 0;
                tb_prop_name.Text = product.Properties.ElementAt(lb_prop.SelectedIndex).Title;

                lb_values.Items.Clear();
                foreach (PropertyOption val in product.Properties.ElementAt(lb_prop.SelectedIndex).Values)
                {
                    string toAdd;
                    if (val.Code == "")
                        toAdd = val.Name;
                    else toAdd = val.Name + " [" + val.Code + "]";

                    lb_values.Items.Add(toAdd);
                }
            }
        }

        private void lb_values_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabled = lb_values.SelectedIndex >= 0;

            btn_value_remove.Enabled = enabled;
            tb_value_prettyname.Enabled = enabled;
            tb_value_code.Enabled = enabled;

            if (enabled && product.Properties.ElementAt(lb_prop.SelectedIndex).Conditional)
            {
                tb_cond_value.Enabled = true;
                cb_cond_op.Enabled = true;
                cb_cond_prop.Enabled = true;

                cb_cond_prop.Items.Clear();

                // set dropdown items
                foreach (ProductProperty prop in product.Properties)
                {
                    if (!prop.Conditional)
                        cb_cond_prop.Items.Add(prop.Title);
                }
            }
            else
            {
                tb_cond_value.Enabled = false;
                cb_cond_op.Enabled = false;
                cb_cond_prop.Enabled = false;
            }

            if (enabled)
            {

                PropertyOption selected = product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex);

                tb_value_prettyname.Text = selected.Name;
                tb_value_code.Text = selected.Code;
                tb_cond_value.Text = selected.ConditionValue;
                cb_cond_op.SelectedIndex = selected.mode == PropertyOption.ConditionMode.IS ? 0 : 1;
                cb_cond_prop.SelectedItem = selected.ConditionPropertyTarget;

            }
        }

        private void cb_prop_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool oldState = product.Properties.ElementAt(lb_prop.SelectedIndex).Conditional;

            if (oldState != (cb_prop_type.SelectedIndex == 1))
            {
                DialogResult dialogResult = MessageBox.Show("Changing this value will delete all current values of the selected property. Continue?", "Skewer", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    product.Properties.ElementAt(lb_prop.SelectedIndex).Values.Clear();
                    lb_values.Items.Clear();
                    product.Properties.ElementAt(lb_prop.SelectedIndex).Conditional = cb_prop_type.SelectedIndex == 1;
                }
                else
                {
                    cb_prop_type.SelectedIndex = oldState ? 1 : 0; // undo
                }
            }
        }

        private void btn_prop_add_Click(object sender, EventArgs e)
        {
            ProductProperty newProperty = new ProductProperty("Untitled Property", false);
            lb_prop.Items.Add("Untitled Property");
            product.Properties.Add(newProperty);
        }

        private void btn_prop_remove_Click(object sender, EventArgs e)
        {
            product.Properties.RemoveAt(lb_prop.SelectedIndex);
            lb_prop.Items.RemoveAt(lb_prop.SelectedIndex);
            lb_values.Items.Clear();
        }

        private void tb_prod_name_Leave(object sender, EventArgs e)
        {
            product.Name = tb_prod_name.Text;
        }

        private void tb_prop_name_Leave(object sender, EventArgs e)
        {

        }

        private void tb_prop_name_TextChanged(object sender, EventArgs e)
        {
            int pos = tb_prop_name.SelectionStart;
            product.Properties.ElementAt(lb_prop.SelectedIndex).Title = tb_prop_name.Text;
            lb_prop.Items[lb_prop.SelectedIndex] = tb_prop_name.Text;
            tb_prop_name.Focus();
            tb_prop_name.DeselectAll();
            tb_prop_name.SelectionStart = pos;
        }

        private void btn_value_add_Click(object sender, EventArgs e)
        {
            bool isConditional = product.Properties.ElementAt(lb_prop.SelectedIndex).Conditional;
            PropertyOption option;

            if (isConditional) option = PropertyOption.Create("New Value", "", true, PropertyOption.ConditionMode.ISNT, "", "");
            else option = PropertyOption.Create("New Value", "");

            lb_values.Items.Add(option.Name);
            product.Properties.ElementAt(lb_prop.SelectedIndex).Values.Add(option);
        }

        private void btn_value_remove_Click(object sender, EventArgs e)
        {
            product.Properties.ElementAt(lb_prop.SelectedIndex).Values.RemoveAt(lb_values.SelectedIndex);
            lb_values.Items.RemoveAt(lb_values.SelectedIndex);
        }

        private void tb_value_prettyname_TextChanged(object sender, EventArgs e)
        {
            int pos = tb_value_prettyname.SelectionStart;
            product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Name = tb_value_prettyname.Text;

            string newListItem = product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Name;
            string code = product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Code;

            if (code != "")
                newListItem += " [" + code + "]";

            lb_values.Items[lb_values.SelectedIndex] = newListItem;

            tb_value_prettyname.Focus();
            tb_value_prettyname.DeselectAll();
            tb_value_prettyname.SelectionStart = pos;
        }

        private void tb_value_code_TextChanged(object sender, EventArgs e)
        {
            int pos = tb_value_code.SelectionStart;
            product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Code = tb_value_code.Text;

            string newListItem = product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Name;
            string code = product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).Code;

            if (code != "")
                newListItem += " [" + code + "]";

            lb_values.Items[lb_values.SelectedIndex] = newListItem;

            tb_value_code.Focus();
            tb_value_code.DeselectAll();
            tb_value_code.SelectionStart = pos;
        }

        private void tb_prod_name_TextChanged(object sender, EventArgs e)
        {
            product.Name = tb_prod_name.Text;
        }

        private void tb_prod_comment_TextChanged(object sender, EventArgs e)
        {
            product.Comment = tb_prod_comment.Text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            product.Save(filepath);
        }

        private void btn_save_as_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML Files|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filepath = sfd.FileName;
                    product.Save(filepath);
                }
            }
        }

        private void cb_cond_op_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_prop.SelectedIndex >= 0 && lb_values.SelectedIndex >= 0)
            {
                PropertyOption.ConditionMode newMode = cb_cond_op.SelectedIndex == 0 ? PropertyOption.ConditionMode.IS : PropertyOption.ConditionMode.ISNT;
                product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).mode = newMode;
            }
        }

        private void cb_cond_prop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_prop.SelectedIndex >= 0 && lb_values.SelectedIndex >= 0)
                product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).ConditionPropertyTarget = cb_cond_prop.SelectedItem as string;
        }

        private void tb_cond_value_TextChanged(object sender, EventArgs e)
        {
            product.Properties.ElementAt(lb_prop.SelectedIndex).Values.ElementAt(lb_values.SelectedIndex).ConditionValue = tb_cond_value.Text;
        }
    }
}
