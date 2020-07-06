using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKU_Maker
{
    public partial class frm_table : Form
    {
        public string[][] data { get; set; }

        public frm_table(string[][] data)
        {
            InitializeComponent();

            DataTable grid = new DataTable("grid");

            for (int i = 0; i < data[0].Length; i++)
            {
                DataColumn col = new DataColumn(data[0][i]);
                grid.Columns.Add(col);
            }

            for (int i = 1; i < data.Length; i++)
            {
                DataRow row = grid.NewRow();

                for (int e = 0; e < data[i].Length; e++)
                {
                    row[data[0][e]] = data[i][e];
                }

                grid.Rows.Add(row);
            }

            dgv_main.DataSource = grid; // show grid
        }
    }
}
