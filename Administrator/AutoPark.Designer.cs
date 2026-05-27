namespace Carshering
{
    partial class AutoPark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаденьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пробегDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владелецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автопаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Carshering.Database1DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.автопаркTableAdapter = new Carshering.Database1DataSetTableAdapters.АвтопаркTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАвтомобиляDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.ценаденьDataGridViewTextBoxColumn,
            this.госНомерDataGridViewTextBoxColumn,
            this.пробегDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.состояниеDataGridViewTextBoxColumn,
            this.владелецDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автопаркBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDАвтомобиляDataGridViewTextBoxColumn
            // 
            this.iDАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "ID автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.HeaderText = "ID автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.Name = "iDАвтомобиляDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            // 
            // ценаденьDataGridViewTextBoxColumn
            // 
            this.ценаденьDataGridViewTextBoxColumn.DataPropertyName = "Цена/день";
            this.ценаденьDataGridViewTextBoxColumn.HeaderText = "Цена/день";
            this.ценаденьDataGridViewTextBoxColumn.Name = "ценаденьDataGridViewTextBoxColumn";
            // 
            // госНомерDataGridViewTextBoxColumn
            // 
            this.госНомерDataGridViewTextBoxColumn.DataPropertyName = "ГосНомер";
            this.госНомерDataGridViewTextBoxColumn.HeaderText = "ГосНомер";
            this.госНомерDataGridViewTextBoxColumn.Name = "госНомерDataGridViewTextBoxColumn";
            // 
            // пробегDataGridViewTextBoxColumn
            // 
            this.пробегDataGridViewTextBoxColumn.DataPropertyName = "Пробег";
            this.пробегDataGridViewTextBoxColumn.HeaderText = "Пробег";
            this.пробегDataGridViewTextBoxColumn.Name = "пробегDataGridViewTextBoxColumn";
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "ГодВыпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "ГодВыпуска";
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            // 
            // владелецDataGridViewTextBoxColumn
            // 
            this.владелецDataGridViewTextBoxColumn.DataPropertyName = "Владелец";
            this.владелецDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.владелецDataGridViewTextBoxColumn.Name = "владелецDataGridViewTextBoxColumn";
            // 
            // автопаркBindingSource
            // 
            this.автопаркBindingSource.DataMember = "Автопарк";
            this.автопаркBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(887, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 33);
            this.button5.TabIndex = 23;
            this.button5.Text = "Клиенты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(119, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 33);
            this.button4.TabIndex = 22;
            this.button4.Text = "Автопарк";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Система аренды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(778, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 36);
            this.button6.TabIndex = 31;
            this.button6.Text = "Сменить пользователя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(320, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 33);
            this.button7.TabIndex = 34;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // автопаркTableAdapter
            // 
            this.автопаркTableAdapter.ClearBeforeFill = true;
            // 
            // AutoPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AutoPark";
            this.Text = "AutoPark";
            this.Load += new System.EventHandler(this.AutoPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource автопаркBindingSource;
        private Database1DataSetTableAdapters.АвтопаркTableAdapter автопаркTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаденьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пробегDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn владелецDataGridViewTextBoxColumn;
    }
}