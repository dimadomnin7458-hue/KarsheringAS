using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carshering
{
    public partial class AutoPark : Form
    {
        public AutoPark()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ArendSystem newForm1 = new ArendSystem();
            newForm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            People newForm2 = new People();
            newForm2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже на этой таблице");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm4 = new Form1();
            newForm4.Show();
        }

        private void AutoPark_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
