using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Carshering
{
    public partial class NewMan : Form
    {
        public NewMan()
        {
            InitializeComponent();
        }

        private void NewMan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = this.людиTableAdapter.Connection.ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                // ID человека не пишем, так как это Счетчик
                string sql = "INSERT INTO [Люди] ([Фамилия], [Имя], [Отчество], [Серия], [Номер], [Номер телефона]) " +
                             "VALUES (?, ?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("?", textBox1.Text);
                    cmd.Parameters.AddWithValue("?", textBox2.Text);
                    cmd.Parameters.AddWithValue("?", textBox3.Text);
                    cmd.Parameters.AddWithValue("?", textBox4.Text);
                    cmd.Parameters.AddWithValue("?", textBox5.Text);
                    cmd.Parameters.AddWithValue("?", textBox6.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно зарегистрированы в базе клиентов!");
                    }
                    catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Arenda newForm14 = new Arenda();
        }
    }
    
}
