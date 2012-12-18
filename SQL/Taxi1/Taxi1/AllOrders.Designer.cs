namespace Taxi1
{
	partial class frmAllOrders
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
			this.scAllOrders = new System.Windows.Forms.SplitContainer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbInProc = new System.Windows.Forms.RadioButton();
			this.rbFinished = new System.Windows.Forms.RadioButton();
			this.rbAllOrders = new System.Windows.Forms.RadioButton();
			this.grdvOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.scAllOrders)).BeginInit();
			this.scAllOrders.Panel1.SuspendLayout();
			this.scAllOrders.Panel2.SuspendLayout();
			this.scAllOrders.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// scAllOrders
			// 
			this.scAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scAllOrders.Location = new System.Drawing.Point(0, 0);
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
			this.scAllOrders.Panel2.Controls.Add(this.grdvOrders);
			this.scAllOrders.Size = new System.Drawing.Size(543, 298);
			this.scAllOrders.SplitterDistance = 65;
			this.scAllOrders.TabIndex = 1;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(271, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 22);
			this.button1.TabIndex = 2;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(137, 3);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(122, 21);
			this.comboBox3.TabIndex = 1;
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
			// rbFinished
			// 
			this.rbFinished.AutoSize = true;
			this.rbFinished.Location = new System.Drawing.Point(3, 20);
			this.rbFinished.Name = "rbFinished";
			this.rbFinished.Size = new System.Drawing.Size(137, 17);
			this.rbFinished.TabIndex = 1;
			this.rbFinished.Text = "Выполненные заказы";
			this.rbFinished.UseVisualStyleBackColor = true;
			this.rbFinished.CheckedChanged += new System.EventHandler(this.rbFinished_CheckedChanged);
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
			this.rbAllOrders.CheckedChanged += new System.EventHandler(this.rbAllOrders_CheckedChanged);
			// 
			// grdvOrders
			// 
			this.grdvOrders.AllowUserToAddRows = false;
			this.grdvOrders.AllowUserToDeleteRows = false;
			this.grdvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdvOrders.Location = new System.Drawing.Point(0, 3);
			this.grdvOrders.Name = "grdvOrders";
			this.grdvOrders.ReadOnly = true;
			this.grdvOrders.Size = new System.Drawing.Size(543, 226);
			this.grdvOrders.TabIndex = 0;
			// 
			// frmAllOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 298);
			this.Controls.Add(this.scAllOrders);
			this.Name = "frmAllOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AllOrders";
			this.Load += new System.EventHandler(this.AllOrders_Load);
			this.scAllOrders.Panel1.ResumeLayout(false);
			this.scAllOrders.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scAllOrders)).EndInit();
			this.scAllOrders.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdvOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer scAllOrders;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbInProc;
		private System.Windows.Forms.RadioButton rbFinished;
		private System.Windows.Forms.RadioButton rbAllOrders;
		private System.Windows.Forms.DataGridView grdvOrders;
	}
}