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

namespace Carshering
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
        string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) ||
        string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля для регистрации!");
                return;
            }

            string connectionString = this.людиTableAdapter.Connection.ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Перечисляем столбцы так, как они идут у вас: сначала данные профиля, в конце логин/пароль/роль
                    string query = "INSERT INTO [Люди] ([Фамилия], [Имя], [Отчество], [Серия], [Номер], [Номер телефона], [username], [password], [Роль]) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // ВАЖНО: Добавляем параметры строго в том порядке, в котором указали столбцы выше
                        command.Parameters.AddWithValue("?", textBox3.Text.Trim()); // Фамилия
                        command.Parameters.AddWithValue("?", textBox4.Text.Trim()); // Имя
                        command.Parameters.AddWithValue("?", textBox5.Text.Trim()); // Отчество
                        command.Parameters.AddWithValue("?", textBox6.Text.Trim()); // Серия
                        command.Parameters.AddWithValue("?", textBox7.Text.Trim()); // Номер
                        command.Parameters.AddWithValue("?", textBox8.Text.Trim()); // Телефон

                        command.Parameters.AddWithValue("?", textBox1.Text.Trim()); // username (из textbox1)
                        command.Parameters.AddWithValue("?", textBox2.Text.Trim()); // password (из textbox2)
                        command.Parameters.AddWithValue("?", "Покупатель");         // Роль

                        command.ExecuteNonQuery();

                        MessageBox.Show("Регистрация успешно завершена!");

                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при регистрации: " + ex.Message);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Люди". При необходимости она может быть перемещена или удалена.
            this.людиTableAdapter.Fill(this.database1DataSet.Люди);

        }

    }
}
