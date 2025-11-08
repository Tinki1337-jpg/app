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


namespace MyApp
{
    public partial class Form2 : Form

    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Успеваемость студента.accdb";
        private OleDbConnection myConnection;

        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.успеваемость_студентаDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.успеваемость_студентаDataSet.Студенты);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox4.Text);
            String number = textBox1.Text;
            String groups = textBox2.Text;
            String FIO = textBox3.Text;
            String Date = textBox5.Text;
            String Grants = textBox6.Text;
            string query = "Insert INTO Студенты([КодСтудента], НомерЗачетки, КодГруппы, ФИО, ДатаРождения, Стипендия) VALUES (" + kod + ",'" + number + "','" + groups + "', '" + FIO + "','"+ Date + "','" + Grants + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Студент добавлен");
            







        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox7.Text);
            string query = "DELETE FROM Студенты WHERE [КодСтудента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Студент удален");
            this.студентыTableAdapter.Fill(this.успеваемость_студентаDataSet.Студенты);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Update(this.успеваемость_студентаDataSet.Студенты);
        }
    }
}
