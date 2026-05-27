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
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже на этой таблице");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm4 = new Form1();
            newForm4.Show();
        }

        private void People_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
