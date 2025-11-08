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
    public partial class Form7 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Успеваемость студента.accdb";
        private OleDbConnection myConnection;
        public Form7()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.успеваемость_студентаDataSet.Дисциплины);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet3.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter1.Fill(this.успеваемость_студентаDataSet3.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet3.Посещаемость". При необходимости она может быть перемещена или удалена.
            this.посещаемостьTableAdapter1.Fill(this.успеваемость_студентаDataSet3.Посещаемость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.успеваемость_студентаDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet2.Посещаемость". При необходимости она может быть перемещена или удалена.
            this.посещаемостьTableAdapter.Fill(this.успеваемость_студентаDataSet2.Посещаемость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.посещаемостьTableAdapter1.Update(this.успеваемость_студентаDataSet3.Посещаемость);
            this.посещаемостьTableAdapter.Update(this.успеваемость_студентаDataSet2.Посещаемость);
        }
    }
}
