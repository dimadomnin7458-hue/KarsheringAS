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
    public partial class AutoPark_user : Form
    {
        public AutoPark_user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ArendaForm newForm1 = new ArendaForm();
            newForm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm4 = new Form1();
            newForm4.Show();
        }

        private void AutoPark_user_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);

        }
    }
}
