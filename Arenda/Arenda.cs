using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Carshering
{
    public partial class Arenda : Form
    {
        private int currentUserId;

        public Arenda(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        public Arenda() { InitializeComponent(); }

        private void Arenda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.database1DataSet.Пользователи);
            // Убираем отладочные try/catch, если данные в комбобоксах уже появились
            LoadData();
        }

        private void LoadData()
        {
            string connString = this.пользователиTableAdapter.Connection.ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 1. Загрузка машин (без изменений)
                    string sqlCars = "SELECT [ID автомобиля], [Модель] & ' (' & [Цвет] & ')' AS CarName, [Цена/день] FROM [Автопарк]";
                    OleDbDataAdapter daCars = new OleDbDataAdapter(sqlCars, conn);
                    DataTable dtCars = new DataTable();
                    daCars.Fill(dtCars);
                    comboBox2.DataSource = dtCars;
                    comboBox2.DisplayMember = "CarName";
                    comboBox2.ValueMember = "ID автомобиля";

                    // 2. Загрузка ФИО ТОЛЬКО для текущего пользователя
                    // Используем currentUserId, который мы получили при входе
                    string sqlPeople = "SELECT [ID человека], [Фамилия] & ' ' & [Имя] & ' ' & [Отчество] AS FullName " +
                                       "FROM [Люди] WHERE [ID человека] = ?";

                    OleDbCommand cmdPeople = new OleDbCommand(sqlPeople, conn);
                    cmdPeople.Parameters.AddWithValue("?", currentUserId); // Фильтруем по ID вошедшего

                    OleDbDataAdapter daPeople = new OleDbDataAdapter(cmdPeople);
                    DataTable dtPeople = new DataTable();
                    daPeople.Fill(dtPeople);

                    comboBox1.DataSource = dtPeople;
                    comboBox1.DisplayMember = "FullName";
                    comboBox1.ValueMember = "ID человека";

                    // Выбираем этого пользователя сразу, так как он там один
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }

                    comboBox2.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Выберите пользователя и автомобиль!");
                return;
            }

            string connString = this.пользователиTableAdapter.Connection.ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string sqlInsert = "INSERT INTO [Система аренды] " +
                                 "([ID человека], [ID автомобиля], [Сумма к оплате], [Дата начала аренды], [Дата окончания аренды], [Активный заказ или нет]) " +
                                 "VALUES (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(sqlInsert, conn))
                    {
                        // Берем ID человека напрямую из comboBox1
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(comboBox1.SelectedValue);

                        // ID автомобиля из comboBox2
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(comboBox2.SelectedValue);

                        decimal sum;
                        decimal.TryParse(textBox1.Text, out sum);
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = sum;

                        cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker1.Value.Date;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = dateTimePicker2.Value.Date;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Активен";

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Аренда успешно оформлена на {comboBox1.Text}!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }
            }
        }


        private void CalculateSum()
        {
            // Проверяем, что в списке машин что-то выбрано
        }

            private void button6_Click(object sender, EventArgs e)
            {
                this.Close();
                Form1 newForm4 = new Form1();
                newForm4.Show();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox2.SelectedItem is DataRowView row)
                {
                    try
                    {
                        // Получаем цену из колонки [Цена/день] таблицы Автопарк
                        decimal pricePerDay = Convert.ToDecimal(row["Цена/день"]);

                        // Считаем разницу в днях
                        int days = (dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).Days;

                        // Если аренда в тот же день — это 1 день, если дней меньше 0 — ошибка
                        if (days < 0)
                        {
                            textBox1.Text = "0";
                            return;
                        }
                        if (days == 0) days = 1;

                        // Считаем итог и пишем в TextBox
                        decimal total = days * pricePerDay;
                        textBox1.Text = total.ToString();
                    }
                    catch { textBox1.Text = "0"; }
                }

            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
            NewMan newForm8 = new NewMan();
            newForm8.Show();
        }
    }
    
}
