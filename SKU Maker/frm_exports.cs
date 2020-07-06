using System;
using System.CodeDom;
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
        public string[][] Skus { get; set; }
        public Product p { get; set; }

        public frm_exports(Product p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void frm_exports_Load(object sender, EventArgs e)
        {
            List<List<PropertyOption>> rows = NextMutable(p, 0);

            List<ProductProperty> mutableProperties = new List<ProductProperty>();
            List<ProductProperty> conditionalProperties = new List<ProductProperty>();

            foreach (ProductProperty prop in p.Properties)
            {
                if (prop.Conditional) conditionalProperties.Add(prop);
                else mutableProperties.Add(prop);
            }


            for (int i = 0; i < rows.Count; i++)
            {
                List<PropertyOption> row = rows[i];
                foreach (ProductProperty prop in conditionalProperties)
                {
                    PropertyOption selected = null;
                    foreach (PropertyOption possible in prop.Values)
                    {
                        if (selected != null) continue; // fast forward through rest of loop if selection has been made

                        List<string> mutablePropStr = new List<string>();
                        foreach (ProductProperty @this in mutableProperties) { mutablePropStr.Add(@this.Title); }

                        if (possible.mode == PropertyOption.ConditionMode.IS)
                        {
                            if (row[mutablePropStr.IndexOf(possible.ConditionPropertyTarget)].Name == possible.ConditionValue)
                                selected = possible;
                        }
                        else
                        {
                            if (row[mutablePropStr.IndexOf(possible.ConditionPropertyTarget)].Name != possible.ConditionValue)
                                selected = possible;
                        }
                    }

                    row.Add(selected);
                }
            }


            // Create SKUs

            for (int i = 0; i < rows.Count; i++)
            {
                List<PropertyOption> row = rows[i];
                string sku = "";

                foreach (SkuComponent skuComponent in p.SkuSchema)
                {
                    switch (skuComponent.Type)
                    {
                        case SkuComponent.SkuComponentType.STATIC:
                            sku += skuComponent.StaticText;
                            break;
                        case SkuComponent.SkuComponentType.NULL:
                            continue;
                        default:
                            int index = -1;
                            for(int j = 0; j < mutableProperties.Count; j++)
                            {
                                ProductProperty @this = mutableProperties[j];
                                if (skuComponent.Property.Title == @this.Title)
                                    index = j;
                            }

                            if (index < 0) sku += "";
                            else sku += row[index].Code;
                            break;
                    }
                }

                rows[i].Insert(0, new PropertyOption { Name = sku } as PropertyOption);
            }


            string[][] strs = new string[rows.Count + 1][];
            List<string> headers = new List<string>() { "SKU" };
            foreach (ProductProperty @this in mutableProperties) { headers.Add(@this.Title); }
            foreach (ProductProperty @this in conditionalProperties) { headers.Add(@this.Title); }

            strs[0] = headers.ToArray();

            for (int i = 0; i < rows.Count; i++)
            {
                string[] arr = new string[rows[i].Count];
                for (int j = 0; j < arr.Length; j++) { arr[j] = rows[i][j].Name; }
                strs[i + 1] = arr;
            }

            Form table = new frm_table(strs);
            table.Show();
            this.Close();
        }

        private List<List<PropertyOption>> NextMutable(Product p, int col)
        {
            if (col >= p.Properties.Count)
                return new List<List<PropertyOption>>(); // when the end is reached, start working back
            if (p.Properties.ElementAt(col).Conditional)
                return NextMutable(p, col + 1); // skip any conditional properties for now

            List<List<PropertyOption>> rows = new List<List<PropertyOption>>();

            foreach (PropertyOption possibility in p.Properties.ElementAt(col).Values)
            {
                List<List<PropertyOption>> others = NextMutable(p, col + 1);
                if (others.Count == 0)
                    rows.Add(new List<PropertyOption>() { possibility });

                foreach (List<PropertyOption> other in others)
                {
                    List<PropertyOption> row = new List<PropertyOption>();
                    row.Add(possibility);
                    foreach (PropertyOption val in other)
                    {
                        row.Add(val);
                    }
                    rows.Add(row);
                }
            }

            return rows;
        }
    }
}
