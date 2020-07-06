using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKU_Maker
{
    public partial class frm_exports : Form
    {
        public List<Product> Products { get; set; }
        public string[][] Skus { get; set; }

        public frm_exports(List<Product> products)
        {
            InitializeComponent();
            this.Products = products;
        }

        private void frm_exports_Load(object sender, EventArgs e)
        {
            pb_main.Value = 0;
            int totalSkusNeeded = 0;

            foreach (Product p in Products)
            {
                int productSkusNeeded = 1;
                foreach (ProductProperty prop in p.Properties)
                {
                    if (!prop.Conditional)
                        productSkusNeeded *= prop.Values.Count;
                }
                totalSkusNeeded += productSkusNeeded;
            }

            l_main.Text = "0/" + totalSkusNeeded;

            List<List<string>> rows = NextMutable(Products[0], 0);
            List<string> mutableProperties = new List<string>();
            List<ProductProperty> conditionalProperties = new List<ProductProperty>();

            foreach (ProductProperty prop in Products[0].Properties)
            {
                if (prop.Conditional) conditionalProperties.Add(prop);
                else mutableProperties.Add(prop.Title);
            }


            for (int i = 0; i < rows.Count; i++)
            {
                List<string> row = rows[i];
                foreach (ProductProperty prop in conditionalProperties)
                {
                    PropertyOption selected = null;
                    foreach (PropertyOption possible in prop.Values)
                    {
                        if (selected != null) continue; // fast forward through rest of loop if selection has been made
                        if (possible.mode == PropertyOption.ConditionMode.IS)
                        {
                            if (row[mutableProperties.IndexOf(possible.ConditionPropertyTarget)] == possible.ConditionValue)
                                selected = possible;
                        }
                        else
                        {
                            if (row[mutableProperties.IndexOf(possible.ConditionPropertyTarget)] != possible.ConditionValue)
                                selected = possible;
                        }
                    }

                    if (selected == null)
                        row.Add("N/A");
                    else
                        row.Add(selected.Name);
                }
            }


            string[][] strs = new string[rows.Count + 1][];
            List<string> headers = new List<string>();
            foreach (string s in mutableProperties) { headers.Add(s); }
            foreach (ProductProperty p in conditionalProperties) { headers.Add(p.Title); }

            strs[0] = headers.ToArray();

            for (int i = 0; i < rows.Count; i++)
            {
                strs[i + 1] = rows[i].ToArray();
            }



            Form table = new frm_table(strs);
            table.Show();
            this.Close();
        }

        private List<List<string>> NextMutable(Product p, int col)
        {
            if (col >= p.Properties.Count)
                return new List<List<string>>();
            if (p.Properties.ElementAt(col).Conditional)
                return NextMutable(p, col + 1); // skip any conditional properties for now

            List<List<string>> rows = new List<List<string>>();

            foreach (PropertyOption possibility in p.Properties.ElementAt(col).Values)
            {
                List<List<string>> others = NextMutable(p, col + 1);
                if (others.Count == 0)
                    rows.Add(new List<string>() { possibility.Name });

                foreach (List<string> other in others)
                {
                    List<string> row = new List<string>();
                    row.Add(possibility.Name);
                    foreach (string val in other)
                    {
                        row.Add(val);
                    }
                    rows.Add(row);
                }
            }

            return rows;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
