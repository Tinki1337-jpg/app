using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet11.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter1.Fill(this.успеваемость_студентаDataSet11.Факультеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter.Fill(this.успеваемость_студентаDataSet.Факультеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "успеваемость_студентаDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.успеваемость_студентаDataSet.Дисциплины);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
