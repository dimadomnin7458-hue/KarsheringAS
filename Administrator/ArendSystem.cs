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
    public partial class ArendSystem : Form
    {
        public ArendSystem()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AutoPark newForm1 = new AutoPark();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже на этой таблице");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newForm4 = new Form1();
            newForm4.Show();
        }

        private void ArendSystem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Система_аренды". При необходимости она может быть перемещена или удалена.
            this.система_арендыTableAdapter.Fill(this.database1DataSet.Система_аренды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Система_аренды". При необходимости она может быть перемещена или удалена.
            this.система_арендыTableAdapter.Fill(this.database1DataSet.Система_аренды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Система_аренды". При необходимости она может быть перемещена или удалена.
            this.система_арендыTableAdapter.Fill(this.database1DataSet.Система_аренды);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.системаАрендыBindingSource.EndEdit();

                // Здесь вызываем обновление
                int result = this.система_арендыTableAdapter.Update(this.database1DataSet.Система_аренды);

                // Проверяем результат операции
                if (result > 0)
                {
                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.система_арендыTableAdapter.Fill(this.database1DataSet.Система_аренды);
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Конфликт при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Ошибка связи с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

