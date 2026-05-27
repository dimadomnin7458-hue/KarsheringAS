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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            string username = textBox1.Text.Trim();
            string connectionString = this.людиTableAdapter.Connection.ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Выбираем сразу ID и Роль (убедись, что поле называется ID)
                    string query = "SELECT [ID человека], [Роль] FROM [Люди] WHERE [username] = ? AND [password] = ?";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", username);
                        command.Parameters.AddWithValue("?", textBox2.Text.Trim());

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["ID человека"]);
                                string role = reader["Роль"].ToString();

                                MessageBox.Show($"Добро пожаловать! Ваша роль: {role}");

                                if (role == "Покупатель")
                                {
                                    Arenda buyerFrm = new Arenda(userId);
                                    buyerFrm.Show();
                                }
                                else if (role == "Администратор")
                                {
                                    ArendSystem adminFrm = new ArendSystem(); // Если админу нужен ID, добавь так же
                                    adminFrm.Show();
                                }
                                else
                                {
                                    AutoPark_user userFrm = new AutoPark_user();
                                    userFrm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка БД: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            Register newForm2 = new Register();
            newForm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
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
