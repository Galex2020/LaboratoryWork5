using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateDifference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void SetDataGridView(DataGridView data)
        {
            data.Columns.Clear();
            data.Rows.Clear();

            var rand = new Random(DateTime.Now.Millisecond);

            for (var j = 1; j < 29; j++)
            {
                data.Columns.Add($"col{j}", j.ToString());
                //data.Columns[j - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            for (var i = 0; i < 12; i++)
            {
                var rowdata = new object[28];

                for (int k = 0; k < 28; k++)
                    rowdata[k] = rand.Next(0, 21);

                data.Rows.Add(rowdata);
                
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetDataGridView(dataGridView1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetDataGridView(dataGridView2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            for (var j = 1; j < 29; j++)
            {
                dataGridView3.Columns.Add($"col{j}", j.ToString());
                //dataGridView3.Columns[j - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            for (var i = 0; i < 12; i++)
            {
                dataGridView3.Rows.Add();
            }

            for (int j = 0; j < 28; j++)
                for (int i = 0; i < 12; i++)
                    dataGridView3[j, i].Value = int.Parse(dataGridView2[j, i].Value.ToString()) - int.Parse(dataGridView1[j, i].Value.ToString());
        }
    }
}
