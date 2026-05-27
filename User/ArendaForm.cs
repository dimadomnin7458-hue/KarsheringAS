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
    public partial class ArendaForm : Form
    {
        public ArendaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AutoPark_user newForm1 = new AutoPark_user();
            newForm1.Show();
        }

        private void ArendaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автопарк". При необходимости она может быть перемещена или удалена.
            this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);

        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите хотя бы модель автомобиля!");
                return;
            }

            string connectionString = this.автопаркTableAdapter.Connection.ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // ID не пишем, Access добавит его сам
                    string query = "INSERT INTO [Автопарк] ([Модель], [Цвет], [Цена/день], [ГосНомер], [Пробег], [ГодВыпуска], [Состояние], [Владелец]) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавляем параметры строго в том порядке, в котором они перечислены в INSERT INTO
                        command.Parameters.AddWithValue("?", textBox1.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox2.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox3.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox4.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox5.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox6.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox7.Text.Trim());
                        command.Parameters.AddWithValue("?", textBox8.Text.Trim());

                        command.ExecuteNonQuery();

                        MessageBox.Show("Автомобиль успешно добавлен в базу!");

                        // Обновляем таблицу на форме, чтобы сразу увидеть результат
                        this.автопаркTableAdapter.Fill(this.database1DataSet.Автопарк);

                        // Очищаем поля после добавления
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении: " + ex.Message);
                }
            }
        }
    }
    
}
