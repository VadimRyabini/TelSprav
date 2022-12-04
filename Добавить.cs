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
    public partial class Добавить : Form
    {public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Телефонный справочник2.mdb";
        private OleDbConnection myConnection;
        public Добавить()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Добавить_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox4.Text);
            string name = textBox1.Text;
            string fam = textBox2.Text;
            int nom = Convert.ToInt32 (textBox3.Text);
            string query = "INSERT INTO Справочник ([Код сотрудника], Фамилия, Имя, [Номер телефона] ) VALUES (" + kod + ", '" + fam + "','" + name + "','" + nom + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные добавлена");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
