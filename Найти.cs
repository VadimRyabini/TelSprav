using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Найти : Form
    {
        public Найти()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            if (form1 != null)
            {
                for (int i = 0; i < form1.dataGridView1.RowCount; i++)
                {
                    form1.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < form1.dataGridView1.ColumnCount; j++)
                        if (form1.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (form1.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                form1.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
