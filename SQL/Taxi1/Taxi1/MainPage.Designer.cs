namespace Taxi1
{
	partial class frmMain
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
			this.btnExit = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabNewOrder = new System.Windows.Forms.TabPage();
			this.tabAllOrders = new System.Windows.Forms.TabPage();
			this.tabPayments = new System.Windows.Forms.TabPage();
			this.scNewOrder = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.pnlCarDriver = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnNewOrder = new System.Windows.Forms.Button();
			this.scAllOrders = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbAllOrders = new System.Windows.Forms.RadioButton();
			this.rbFinished = new System.Windows.Forms.RadioButton();
			this.rbInProc = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataSetAllOrders = new Taxi1.DataSetAllOrders();
			this.dataSetAllOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vIEWALLORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vIEW_ALL_ORDERSTableAdapter = new Taxi1.DataSetAllOrdersTableAdapters.VIEW_ALL_ORDERSTableAdapter();
			this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aRRIVALTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabNewOrder.SuspendLayout();
			this.tabAllOrders.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scNewOrder)).BeginInit();
			this.scNewOrder.Panel1.SuspendLayout();
			this.scNewOrder.Panel2.SuspendLayout();
			this.scNewOrder.SuspendLayout();
			this.pnlCarDriver.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scAllOrders)).BeginInit();
			this.scAllOrders.Panel1.SuspendLayout();
			this.scAllOrders.Panel2.SuspendLayout();
			this.scAllOrders.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAllOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAllOrdersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vIEWALLORDERSBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(463, 334);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(95, 22);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Выход";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabNewOrder);
			this.tabControl1.Controls.Add(this.tabAllOrders);
			this.tabControl1.Controls.Add(this.tabPayments);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(558, 334);
			this.tabControl1.TabIndex = 1;
			// 
			// tabNewOrder
			// 
			this.tabNewOrder.Controls.Add(this.scNewOrder);
			this.tabNewOrder.Location = new System.Drawing.Point(4, 22);
			this.tabNewOrder.Name = "tabNewOrder";
			this.tabNewOrder.Padding = new System.Windows.Forms.Padding(3);
			this.tabNewOrder.Size = new System.Drawing.Size(550, 308);
			this.tabNewOrder.TabIndex = 0;
			this.tabNewOrder.Text = "Новая заявка";
			this.tabNewOrder.UseVisualStyleBackColor = true;
			// 
			// tabAllOrders
			// 
			this.tabAllOrders.Controls.Add(this.scAllOrders);
			this.tabAllOrders.Location = new System.Drawing.Point(4, 22);
			this.tabAllOrders.Name = "tabAllOrders";
			this.tabAllOrders.Padding = new System.Windows.Forms.Padding(3);
			this.tabAllOrders.Size = new System.Drawing.Size(550, 308);
			this.tabAllOrders.TabIndex = 1;
			this.tabAllOrders.Text = "Обработка заказов";
			this.tabAllOrders.UseVisualStyleBackColor = true;
			// 
			// tabPayments
			// 
			this.tabPayments.Location = new System.Drawing.Point(4, 22);
			this.tabPayments.Name = "tabPayments";
			this.tabPayments.Size = new System.Drawing.Size(550, 308);
			this.tabPayments.TabIndex = 2;
			this.tabPayments.Text = "Оплата заказов";
			this.tabPayments.UseVisualStyleBackColor = true;
			// 
			// scNewOrder
			// 
			this.scNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scNewOrder.Location = new System.Drawing.Point(3, 3);
			this.scNewOrder.Name = "scNewOrder";
			this.scNewOrder.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scNewOrder.Panel1
			// 
			this.scNewOrder.Panel1.BackColor = System.Drawing.Color.DarkGray;
			this.scNewOrder.Panel1.Controls.Add(this.textBox5);
			this.scNewOrder.Panel1.Controls.Add(this.textBox4);
			this.scNewOrder.Panel1.Controls.Add(this.textBox3);
			this.scNewOrder.Panel1.Controls.Add(this.textBox2);
			this.scNewOrder.Panel1.Controls.Add(this.textBox1);
			this.scNewOrder.Panel1.Controls.Add(this.label5);
			this.scNewOrder.Panel1.Controls.Add(this.label4);
			this.scNewOrder.Panel1.Controls.Add(this.label3);
			this.scNewOrder.Panel1.Controls.Add(this.label2);
			this.scNewOrder.Panel1.Controls.Add(this.label1);
			// 
			// scNewOrder.Panel2
			// 
			this.scNewOrder.Panel2.BackColor = System.Drawing.Color.Silver;
			this.scNewOrder.Panel2.Controls.Add(this.panel1);
			this.scNewOrder.Panel2.Controls.Add(this.pnlCarDriver);
			this.scNewOrder.Panel2.Controls.Add(this.textBox6);
			this.scNewOrder.Panel2.Controls.Add(this.label6);
			this.scNewOrder.Size = new System.Drawing.Size(544, 302);
			this.scNewOrder.SplitterDistance = 152;
			this.scNewOrder.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя клиента";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Адрес клиента";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Телефон";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(258, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Место назначения";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(258, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Время выезда";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(103, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(131, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(103, 39);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(131, 66);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(362, 39);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(131, 66);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(103, 111);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(131, 20);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(362, 111);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(131, 20);
			this.textBox5.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Дополнительные условия";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(7, 21);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(136, 80);
			this.textBox6.TabIndex = 7;
			// 
			// pnlCarDriver
			// 
			this.pnlCarDriver.Controls.Add(this.label8);
			this.pnlCarDriver.Controls.Add(this.comboBox2);
			this.pnlCarDriver.Controls.Add(this.label7);
			this.pnlCarDriver.Controls.Add(this.comboBox1);
			this.pnlCarDriver.Location = new System.Drawing.Point(156, 6);
			this.pnlCarDriver.Name = "pnlCarDriver";
			this.pnlCarDriver.Size = new System.Drawing.Size(385, 103);
			this.pnlCarDriver.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(4, 21);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(125, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Выбор машины";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(162, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(206, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Выбор водителя (сортировка по стажу)";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(161, 21);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(207, 21);
			this.comboBox2.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.btnNewOrder);
			this.panel1.Location = new System.Drawing.Point(0, 115);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 30);
			this.panel1.TabIndex = 9;
			// 
			// btnNewOrder
			// 
			this.btnNewOrder.Location = new System.Drawing.Point(1, 1);
			this.btnNewOrder.Name = "btnNewOrder";
			this.btnNewOrder.Size = new System.Drawing.Size(116, 27);
			this.btnNewOrder.TabIndex = 0;
			this.btnNewOrder.Text = "Принять заявку";
			this.btnNewOrder.UseVisualStyleBackColor = true;
			// 
			// scAllOrders
			// 
			this.scAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scAllOrders.Location = new System.Drawing.Point(3, 3);
			this.scAllOrders.Name = "scAllOrders";
			this.scAllOrders.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scAllOrders.Panel1
			// 
			this.scAllOrders.Panel1.Controls.Add(this.panel3);
			this.scAllOrders.Panel1.Controls.Add(this.panel2);
			// 
			// scAllOrders.Panel2
			// 
			this.scAllOrders.Panel2.Controls.Add(this.dataGridView1);
			this.scAllOrders.Size = new System.Drawing.Size(544, 302);
			this.scAllOrders.SplitterDistance = 66;
			this.scAllOrders.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbInProc);
			this.panel2.Controls.Add(this.rbFinished);
			this.panel2.Controls.Add(this.rbAllOrders);
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(167, 60);
			this.panel2.TabIndex = 0;
			// 
			// rbAllOrders
			// 
			this.rbAllOrders.AutoSize = true;
			this.rbAllOrders.Checked = true;
			this.rbAllOrders.Location = new System.Drawing.Point(3, 1);
			this.rbAllOrders.Name = "rbAllOrders";
			this.rbAllOrders.Size = new System.Drawing.Size(85, 17);
			this.rbAllOrders.TabIndex = 0;
			this.rbAllOrders.TabStop = true;
			this.rbAllOrders.Text = "Все заказы";
			this.rbAllOrders.UseVisualStyleBackColor = true;
			// 
			// rbFinished
			// 
			this.rbFinished.AutoSize = true;
			this.rbFinished.Location = new System.Drawing.Point(3, 20);
			this.rbFinished.Name = "rbFinished";
			this.rbFinished.Size = new System.Drawing.Size(137, 17);
			this.rbFinished.TabIndex = 1;
			this.rbFinished.Text = "Выполненные заказы";
			this.rbFinished.UseVisualStyleBackColor = true;
			// 
			// rbInProc
			// 
			this.rbInProc.AutoSize = true;
			this.rbInProc.Location = new System.Drawing.Point(3, 40);
			this.rbInProc.Name = "rbInProc";
			this.rbInProc.Size = new System.Drawing.Size(150, 17);
			this.rbInProc.TabIndex = 2;
			this.rbInProc.Text = "Невыполненные заказы";
			this.rbInProc.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERIDDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn,
            this.cOLORDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.aRRIVALTIMEDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.vIEWALLORDERSBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(543, 226);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.comboBox3);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(172, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(370, 60);
			this.panel3.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Изменить статус заказа";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(137, 3);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(122, 21);
			this.comboBox3.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(271, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 22);
			this.button1.TabIndex = 2;
			this.button1.Text = "Выход";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataSetAllOrders
			// 
			this.dataSetAllOrders.DataSetName = "DataSetAllOrders";
			this.dataSetAllOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSetAllOrdersBindingSource
			// 
			this.dataSetAllOrdersBindingSource.DataSource = this.dataSetAllOrders;
			this.dataSetAllOrdersBindingSource.Position = 0;
			// 
			// vIEWALLORDERSBindingSource
			// 
			this.vIEWALLORDERSBindingSource.DataMember = "VIEW_ALL_ORDERS";
			this.vIEWALLORDERSBindingSource.DataSource = this.dataSetAllOrdersBindingSource;
			// 
			// vIEW_ALL_ORDERSTableAdapter
			// 
			this.vIEW_ALL_ORDERSTableAdapter.ClearBeforeFill = true;
			// 
			// oRDERIDDataGridViewTextBoxColumn
			// 
			this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERID";
			this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDERID";
			this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
			this.oRDERIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sTATEDataGridViewTextBoxColumn
			// 
			this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
			this.sTATEDataGridViewTextBoxColumn.HeaderText = "STATE";
			this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
			this.sTATEDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tYPEDataGridViewTextBoxColumn
			// 
			this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
			this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
			this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
			this.tYPEDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cOLORDataGridViewTextBoxColumn
			// 
			this.cOLORDataGridViewTextBoxColumn.DataPropertyName = "COLOR";
			this.cOLORDataGridViewTextBoxColumn.HeaderText = "COLOR";
			this.cOLORDataGridViewTextBoxColumn.Name = "cOLORDataGridViewTextBoxColumn";
			this.cOLORDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// aDDRESSDataGridViewTextBoxColumn
			// 
			this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
			this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
			this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
			this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// aRRIVALTIMEDataGridViewTextBoxColumn
			// 
			this.aRRIVALTIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVALTIME";
			this.aRRIVALTIMEDataGridViewTextBoxColumn.HeaderText = "ARRIVALTIME";
			this.aRRIVALTIMEDataGridViewTextBoxColumn.Name = "aRRIVALTIMEDataGridViewTextBoxColumn";
			this.aRRIVALTIMEDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 355);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnExit);
			this.Name = "frmMain";
			this.Text = "Диспетчерская служба";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Shown += new System.EventHandler(this.frmMain_Shown);
			this.tabControl1.ResumeLayout(false);
			this.tabNewOrder.ResumeLayout(false);
			this.tabAllOrders.ResumeLayout(false);
			this.scNewOrder.Panel1.ResumeLayout(false);
			this.scNewOrder.Panel1.PerformLayout();
			this.scNewOrder.Panel2.ResumeLayout(false);
			this.scNewOrder.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scNewOrder)).EndInit();
			this.scNewOrder.ResumeLayout(false);
			this.pnlCarDriver.ResumeLayout(false);
			this.pnlCarDriver.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.scAllOrders.Panel1.ResumeLayout(false);
			this.scAllOrders.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scAllOrders)).EndInit();
			this.scAllOrders.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAllOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetAllOrdersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vIEWALLORDERSBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabNewOrder;
		private System.Windows.Forms.TabPage tabAllOrders;
		private System.Windows.Forms.TabPage tabPayments;
		private System.Windows.Forms.SplitContainer scNewOrder;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Panel pnlCarDriver;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNewOrder;
		private System.Windows.Forms.SplitContainer scAllOrders;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbInProc;
		private System.Windows.Forms.RadioButton rbFinished;
		private System.Windows.Forms.RadioButton rbAllOrders;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource dataSetAllOrdersBindingSource;
		private DataSetAllOrders dataSetAllOrders;
		private System.Windows.Forms.BindingSource vIEWALLORDERSBindingSource;
		private DataSetAllOrdersTableAdapters.VIEW_ALL_ORDERSTableAdapter vIEW_ALL_ORDERSTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cOLORDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALTIMEDataGridViewTextBoxColumn;

	}
}