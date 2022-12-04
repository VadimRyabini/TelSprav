using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Телефонный справочник2.mdb";
        private OleDbConnection myConnection;
        public Form1()
        { 

            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "телефонный_справочник2DataSet.Справочник". При необходимости она может быть перемещена или удалена.
            this.справочникTableAdapter.Fill(this.телефонный_справочник2DataSet.Справочник);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавить f2 = new Добавить();
            f2.Owner = this;
            f2.ShowDialog();
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.справочникTableAdapter.Fill(this.телефонный_справочник2DataSet.Справочник);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            удалить f3 = new удалить();
            f3.Owner = this;
            f3.ShowDialog();
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            справочникTableAdapter.Update(телефонный_справочник2DataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Найти f4 = new Найти();
            f4.Owner = this;
            f4.ShowDialog();
            myConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
