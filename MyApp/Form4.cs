using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyApp
{
    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Успеваемость студента.accdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter.Fill(this.успеваемость_студентаDataSet.Факультеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.успеваемость_студентаDataSet.Группы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            String faculty = textBox2.Text;
            String groups = textBox3.Text;
            String date = textBox4.Text;
            string query = "Insert INTO Группы([КодГруппы], кодфакультета, Номергруппы, Годсоздания) VALUES (" + kod + ",'" + faculty + "','" + groups + "', '" + date + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Группа добавлена");


        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox5.Text);
            string query = "DELETE FROM Группы WHERE [КодГруппы] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Группа удалена");
            this.группыTableAdapter.Fill(this.успеваемость_студентаDataSet.Группы);
        }
    }
}
