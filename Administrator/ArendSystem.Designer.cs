namespace Carshering
{
    partial class ArendSystem
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
            this.iDАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЧеловекаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаКОплатеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияАрендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.активныйЗаказИлиНетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.системаАрендыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Carshering.Database1DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.система_арендыTableAdapter = new Carshering.Database1DataSetTableAdapters.Система_арендыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.системаАрендыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАрендыDataGridViewTextBoxColumn,
            this.iDЧеловекаDataGridViewTextBoxColumn,
            this.iDАвтомобиляDataGridViewTextBoxColumn,
            this.суммаКОплатеDataGridViewTextBoxColumn,
            this.датаНачалаАрендыDataGridViewTextBoxColumn,
            this.датаОкончанияАрендыDataGridViewTextBoxColumn,
            this.активныйЗаказИлиНетDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.системаАрендыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDАрендыDataGridViewTextBoxColumn
            // 
            this.iDАрендыDataGridViewTextBoxColumn.DataPropertyName = "ID аренды";
            this.iDАрендыDataGridViewTextBoxColumn.HeaderText = "ID аренды";
            this.iDАрендыDataGridViewTextBoxColumn.Name = "iDАрендыDataGridViewTextBoxColumn";
            // 
            // iDЧеловекаDataGridViewTextBoxColumn
            // 
            this.iDЧеловекаDataGridViewTextBoxColumn.DataPropertyName = "ID человека";
            this.iDЧеловекаDataGridViewTextBoxColumn.HeaderText = "ID человека";
            this.iDЧеловекаDataGridViewTextBoxColumn.Name = "iDЧеловекаDataGridViewTextBoxColumn";
            // 
            // iDАвтомобиляDataGridViewTextBoxColumn
            // 
            this.iDАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "ID автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.HeaderText = "ID автомобиля";
            this.iDАвтомобиляDataGridViewTextBoxColumn.Name = "iDАвтомобиляDataGridViewTextBoxColumn";
            // 
            // суммаКОплатеDataGridViewTextBoxColumn
            // 
            this.суммаКОплатеDataGridViewTextBoxColumn.DataPropertyName = "Сумма к оплате";
            this.суммаКОплатеDataGridViewTextBoxColumn.HeaderText = "Сумма к оплате";
            this.суммаКОплатеDataGridViewTextBoxColumn.Name = "суммаКОплатеDataGridViewTextBoxColumn";
            // 
            // датаНачалаАрендыDataGridViewTextBoxColumn
            // 
            this.датаНачалаАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.HeaderText = "Дата начала аренды";
            this.датаНачалаАрендыDataGridViewTextBoxColumn.Name = "датаНачалаАрендыDataGridViewTextBoxColumn";
            // 
            // датаОкончанияАрендыDataGridViewTextBoxColumn
            // 
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.HeaderText = "Дата окончания аренды";
            this.датаОкончанияАрендыDataGridViewTextBoxColumn.Name = "датаОкончанияАрендыDataGridViewTextBoxColumn";
            // 
            // активныйЗаказИлиНетDataGridViewTextBoxColumn
            // 
            this.активныйЗаказИлиНетDataGridViewTextBoxColumn.DataPropertyName = "Активный заказ или нет";
            this.активныйЗаказИлиНетDataGridViewTextBoxColumn.HeaderText = "Активный заказ или нет";
            this.активныйЗаказИлиНетDataGridViewTextBoxColumn.Name = "активныйЗаказИлиНетDataGridViewTextBoxColumn";
            // 
            // системаАрендыBindingSource
            // 
            this.системаАрендыBindingSource.DataMember = "Система аренды";
            this.системаАрендыBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(779, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Система аренды";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Автопарк";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "Клиенты";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(670, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 36);
            this.button6.TabIndex = 31;
            this.button6.Text = "Сменить пользователя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 33);
            this.button7.TabIndex = 32;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // система_арендыTableAdapter
            // 
            this.система_арендыTableAdapter.ClearBeforeFill = true;
            // 
            // ArendSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArendSystem";
            this.Text = "ArendSystem";
            this.Load += new System.EventHandler(this.ArendSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.системаАрендыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource системаАрендыBindingSource;
        private Database1DataSetTableAdapters.Система_арендыTableAdapter система_арендыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЧеловекаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаКОплатеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияАрендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn активныйЗаказИлиНетDataGridViewTextBoxColumn;
    }
}