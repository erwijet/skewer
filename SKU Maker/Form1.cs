using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.CodeDom;

namespace SKU_Maker
{
    public partial class frm_main : Form
    {
        public List<Product> Products { get; set; }
        public List<SkuComponent> SkuComponents {
            get
            {
                if (lb_products.SelectedIndex < 0)
                    return null;
                return Products.ElementAt(lb_products.SelectedIndex).SkuSchema;
            }
            set
            {
                if (lb_products.SelectedIndex < 0)
                    return;
                Products.ElementAt(lb_products.SelectedIndex).SkuSchema = value;
            }
        }
        public int SelectedSKUIndex { get; set; }

        public frm_main()
        {
            InitializeComponent();
            SelectedSKUIndex = -1;

            SkuComponents = new List<SkuComponent>();
            Products = new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Product Buttons

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML Files|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Product p = Product.Load(ofd.FileName);
                        Products.Add(p);
                        lb_products.Items.Add(p.Name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in loading XML File. Double check the XML is correct. Was this generated with Skewer?", "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_prod_remove_Click(object sender, EventArgs e)
        {
            Products.RemoveAt(lb_products.SelectedIndex);
            lb_products.Items.RemoveAt(lb_products.SelectedIndex);
        }

        private void btn_prod_create_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML Files|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Product product = new Product("Untitled Product");
                    Form frm = new frm_edit_xml(product, sfd.FileName);
                    frm.ShowDialog();
                }
            }
        }

        private void btn_prod_modify_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML Files|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Product product = Product.Load(ofd.FileName);
                    Form editForm = new frm_edit_xml(product, ofd.FileName);
                    editForm.ShowDialog();
                }
            }
        }

        #endregion


        private void tp_sku_Click(object sender, EventArgs e)
        {

        }

        private void lb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_prod_remove.Enabled = lb_products.SelectedItem != null;
            flp_sku.Controls.Clear();
            lb_properties.Items.Clear();
            gb_schema_controls.Enabled = false;

            if (lb_products.SelectedIndex >= 0)
            {
                gb_schema_controls.Enabled = true;

                foreach (SkuComponent comp in Products.ElementAt(lb_products.SelectedIndex).SkuSchema)
                {
                    Label l = new Label();

                    if (comp.Type == SkuComponent.SkuComponentType.STATIC)
                        l.Text = comp.StaticText;
                    else
                        l.Text = "<" + lb_products.SelectedItem + "." + comp.Property.Title + ">";

                    l.Font = new Font(FontFamily.GenericMonospace, 8.0f);
                    l.AutoSize = true;
                    l.Click += skuComponentClicked;
                    flp_sku.Controls.Add(l);
                }

                foreach (ProductProperty prop in Products.ElementAt(lb_products.SelectedIndex).Properties)
                {
                    lb_properties.Items.Add(prop.Title);
                }
            }
        }

        private void SkuSelectionChanged()
        {
            MessageBox.Show(SelectedSKUIndex.ToString());
        }

        private void btn_prop_add_Click(object sender, EventArgs e)
        {
            Label l = new Label();

            if (lb_products.SelectedItem == null || lb_properties.SelectedItem == null)
                return;

            l.Text = "<" + lb_products.SelectedItem + "." + lb_properties.SelectedItem + ">";

            l.Font = new Font(FontFamily.GenericMonospace, 8.0f);
            l.AutoSize = true;
            l.Click += skuComponentClicked;
            flp_sku.Controls.Add(l);

            ProductProperty prop = Products.ElementAt(lb_products.SelectedIndex).Properties.ElementAt(lb_properties.SelectedIndex);
            SkuComponent component = new SkuComponent();
            component.Property = prop;
            SkuComponents.Add(component);
        }

        private void skuComponentClicked(object sender, EventArgs e)
        {
            if (SelectedSKUIndex >= 0)
                (flp_sku.Controls[SelectedSKUIndex] as Label).BorderStyle = BorderStyle.None;
            SelectedSKUIndex = flp_sku.Controls.GetChildIndex(sender as Control);
            (flp_sku.Controls[SelectedSKUIndex] as Label).BorderStyle = BorderStyle.FixedSingle;
        }

        private void btn_static_component_add_Click(object sender, EventArgs e)
        {
            if (tb_static_component.Text == "")
                return;

            Label l = new Label();
            l.Text = tb_static_component.Text;

            l.Font = new Font(FontFamily.GenericMonospace, 8.0f);
            l.AutoSize = true;
            l.Click += skuComponentClicked;
            flp_sku.Controls.Add(l);
            SkuComponent component = new SkuComponent();
            component.StaticText = tb_static_component.Text;
            SkuComponents.Add(component);

            tb_static_component.Text = "";
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (SelectedSKUIndex <= 0)
                return;

            Label temp = flp_sku.Controls[SelectedSKUIndex - 1] as Label;
            flp_sku.Controls.SetChildIndex(flp_sku.Controls[SelectedSKUIndex], SelectedSKUIndex - 1);
            flp_sku.Controls.SetChildIndex(temp, SelectedSKUIndex);
            SkuComponent tempComp = SkuComponents.ElementAt(SelectedSKUIndex - 1);
            SkuComponents[SelectedSKUIndex - 1] = SkuComponents[SelectedSKUIndex];
            SkuComponents[SelectedSKUIndex] = tempComp;

            SelectedSKUIndex--;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (SelectedSKUIndex >= SkuComponents.Count - 1)
                return;

            Label temp = flp_sku.Controls[SelectedSKUIndex + 1] as Label;
            flp_sku.Controls.SetChildIndex(flp_sku.Controls[SelectedSKUIndex], SelectedSKUIndex + 1);
            flp_sku.Controls.SetChildIndex(temp, SelectedSKUIndex);
            
            SkuComponent tempComp = SkuComponents.ElementAt(SelectedSKUIndex + 1);
            SkuComponents[SelectedSKUIndex + 1] = SkuComponents[SelectedSKUIndex];
            SkuComponents[SelectedSKUIndex] = tempComp;

            SelectedSKUIndex++;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (SelectedSKUIndex < 0)
                return;

            flp_sku.Controls.RemoveAt(SelectedSKUIndex);
            SkuComponents.RemoveAt(SelectedSKUIndex);

            SelectedSKUIndex = -1; // unselect
        }

        private void btn_sku_schema_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Skewer SKU Package|*.skupkg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        File.Delete(sfd.FileName);
                    string dir = Path.GetTempPath() + @"\skupgk";
                    Directory.CreateDirectory(dir);

                    foreach (Product p in Products)
                    {
                        p.Save(dir + @"\" + p.Name + ".xml");
                    }

                    ZipFile.CreateFromDirectory(dir, sfd.FileName);

                    foreach (string path in Directory.EnumerateFiles(dir))
                    {
                        File.Delete(path);
                    }

                    Directory.Delete(dir);
                    MessageBox.Show(sfd.FileName + " has been created");
                }
            }
        }

        private void btn_sku_schema_load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Skewer SKU Package|*.skupkg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dir = Path.GetTempPath() + @"\skupgk";

                        foreach (string path in Directory.EnumerateFiles(dir))
                        {
                            File.Delete(path);
                        }

                        Directory.CreateDirectory(dir);

                        ZipFile.ExtractToDirectory(ofd.FileName, dir);
                        foreach (string path in Directory.EnumerateFiles(dir))
                        {
                            Product p = Product.Load(path);
                            Products.Add(p);
                            lb_products.Items.Add(p.Name);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Could not parse " + ofd.Title);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Form frm = new frm_exports(Products);
            frm.Show();
        }
    }
}
