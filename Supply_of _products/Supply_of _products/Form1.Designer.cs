namespace Supply_of__products
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_report = new System.Windows.Forms.Button();
			this.button_food_intake = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.datePicker3 = new System.Windows.Forms.DateTimePicker();
			this.datePicker2 = new System.Windows.Forms.DateTimePicker();
			this.buttonShowNotes = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbGoods = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxWeight = new System.Windows.Forms.TextBox();
			this.btWrite = new System.Windows.Forms.Button();
			this.cmbSuppliers = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.button_report);
			this.panel1.Controls.Add(this.button_food_intake);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(222, 365);
			this.panel1.TabIndex = 0;
			// 
			// button_report
			// 
			this.button_report.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_report.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_report.Location = new System.Drawing.Point(4, 81);
			this.button_report.Name = "button_report";
			this.button_report.Size = new System.Drawing.Size(215, 74);
			this.button_report.TabIndex = 1;
			this.button_report.Text = "Сформировать отчет";
			this.button_report.UseVisualStyleBackColor = false;
			this.button_report.Click += new System.EventHandler(this.button_report_Click);
			// 
			// button_food_intake
			// 
			this.button_food_intake.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button_food_intake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_food_intake.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_food_intake.Location = new System.Drawing.Point(4, 4);
			this.button_food_intake.Name = "button_food_intake";
			this.button_food_intake.Size = new System.Drawing.Size(215, 74);
			this.button_food_intake.TabIndex = 0;
			this.button_food_intake.Text = "Прием товаров";
			this.button_food_intake.UseVisualStyleBackColor = false;
			this.button_food_intake.Click += new System.EventHandler(this.button_food_intake_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.cmbGoods);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.textBoxPrice);
			this.panel2.Controls.Add(this.textBoxWeight);
			this.panel2.Controls.Add(this.btWrite);
			this.panel2.Controls.Add(this.cmbSuppliers);
			this.panel2.Controls.Add(this.dateTimePicker1);
			this.panel2.Location = new System.Drawing.Point(240, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(861, 365);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.datePicker3);
			this.panel3.Controls.Add(this.datePicker2);
			this.panel3.Controls.Add(this.buttonShowNotes);
			this.panel3.Location = new System.Drawing.Point(240, 9);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(861, 365);
			this.panel3.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.Location = new System.Drawing.Point(26, 159);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(820, 194);
			this.dataGridView1.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(239, 8);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(318, 30);
			this.label10.TabIndex = 26;
			this.label10.Text = "Выберите период закупок";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(463, 68);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 24);
			this.label8.TabIndex = 20;
			this.label8.Text = "До:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(93, 68);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 24);
			this.label9.TabIndex = 19;
			this.label9.Text = "От:";
			// 
			// datePicker3
			// 
			this.datePicker3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.datePicker3.Location = new System.Drawing.Point(514, 62);
			this.datePicker3.Margin = new System.Windows.Forms.Padding(4);
			this.datePicker3.Name = "datePicker3";
			this.datePicker3.Size = new System.Drawing.Size(246, 31);
			this.datePicker3.TabIndex = 18;
			// 
			// datePicker2
			// 
			this.datePicker2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.datePicker2.Location = new System.Drawing.Point(143, 62);
			this.datePicker2.Margin = new System.Windows.Forms.Padding(4);
			this.datePicker2.Name = "datePicker2";
			this.datePicker2.Size = new System.Drawing.Size(247, 31);
			this.datePicker2.TabIndex = 17;
			// 
			// buttonShowNotes
			// 
			this.buttonShowNotes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.buttonShowNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonShowNotes.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShowNotes.Location = new System.Drawing.Point(165, 109);
			this.buttonShowNotes.Margin = new System.Windows.Forms.Padding(4);
			this.buttonShowNotes.Name = "buttonShowNotes";
			this.buttonShowNotes.Size = new System.Drawing.Size(483, 43);
			this.buttonShowNotes.TabIndex = 16;
			this.buttonShowNotes.Text = "Показать записи";
			this.buttonShowNotes.UseVisualStyleBackColor = false;
			this.buttonShowNotes.Click += new System.EventHandler(this.buttonShowNotes_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(254, 17);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(303, 30);
			this.label11.TabIndex = 30;
			this.label11.Text = "Введите данные закупки";
			// 
			// cmbGoods
			// 
			this.cmbGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGoods.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbGoods.FormattingEnabled = true;
			this.cmbGoods.Location = new System.Drawing.Point(578, 81);
			this.cmbGoods.Margin = new System.Windows.Forms.Padding(4);
			this.cmbGoods.Name = "cmbGoods";
			this.cmbGoods.Size = new System.Drawing.Size(243, 31);
			this.cmbGoods.TabIndex = 29;
			this.cmbGoods.SelectedIndexChanged += new System.EventHandler(this.cmbGoods_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(31, 84);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 24);
			this.label7.TabIndex = 25;
			this.label7.Text = "Поставщик:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(34, 191);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 24);
			this.label6.TabIndex = 24;
			this.label6.Text = "Дата:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(481, 135);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 24);
			this.label5.TabIndex = 23;
			this.label5.Text = "Цена:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(31, 136);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "Вес:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(481, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 21;
			this.label3.Text = "Товар:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(675, 133);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "руб/кг";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(265, 140);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "кг";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPrice.Location = new System.Drawing.Point(578, 133);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(79, 31);
			this.textBoxPrice.TabIndex = 18;
			this.textBoxPrice.Text = "0.00";
			this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxWeight
			// 
			this.textBoxWeight.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxWeight.Location = new System.Drawing.Point(178, 135);
			this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxWeight.Name = "textBoxWeight";
			this.textBoxWeight.Size = new System.Drawing.Size(79, 31);
			this.textBoxWeight.TabIndex = 17;
			this.textBoxWeight.Text = "0,0";
			this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
			// 
			// btWrite
			// 
			this.btWrite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btWrite.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btWrite.Location = new System.Drawing.Point(165, 278);
			this.btWrite.Margin = new System.Windows.Forms.Padding(4);
			this.btWrite.Name = "btWrite";
			this.btWrite.Size = new System.Drawing.Size(483, 43);
			this.btWrite.TabIndex = 16;
			this.btWrite.Text = "Записать в БД";
			this.btWrite.UseVisualStyleBackColor = false;
			this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
			// 
			// cmbSuppliers
			// 
			this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSuppliers.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbSuppliers.FormattingEnabled = true;
			this.cmbSuppliers.Location = new System.Drawing.Point(178, 81);
			this.cmbSuppliers.Margin = new System.Windows.Forms.Padding(4);
			this.cmbSuppliers.Name = "cmbSuppliers";
			this.cmbSuppliers.Size = new System.Drawing.Size(243, 31);
			this.cmbSuppliers.TabIndex = 14;
			this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Location = new System.Drawing.Point(178, 191);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(243, 31);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1113, 392);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SupplyOfProducts";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_report;
		private System.Windows.Forms.Button button_food_intake;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxWeight;
		private System.Windows.Forms.Button btWrite;
		private System.Windows.Forms.ComboBox cmbSuppliers;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cmbGoods;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker datePicker3;
		private System.Windows.Forms.DateTimePicker datePicker2;
		private System.Windows.Forms.Button buttonShowNotes;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label11;
	}
}

