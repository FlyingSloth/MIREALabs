namespace Taxi1
{
	partial class frmLogin
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
			this.cbUsers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtbPass = new System.Windows.Forms.TextBox();
			this.chbPass = new System.Windows.Forms.CheckBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbUsers
			// 
			this.cbUsers.FormattingEnabled = true;
			this.cbUsers.Location = new System.Drawing.Point(11, 38);
			this.cbUsers.Name = "cbUsers";
			this.cbUsers.Size = new System.Drawing.Size(158, 21);
			this.cbUsers.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выберите имя пользователя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Введите Ваш пароль";
			// 
			// txtbPass
			// 
			this.txtbPass.ForeColor = System.Drawing.SystemColors.Window;
			this.txtbPass.Location = new System.Drawing.Point(11, 95);
			this.txtbPass.Name = "txtbPass";
			this.txtbPass.Size = new System.Drawing.Size(157, 20);
			this.txtbPass.TabIndex = 3;
			// 
			// chbPass
			// 
			this.chbPass.AutoSize = true;
			this.chbPass.Location = new System.Drawing.Point(12, 125);
			this.chbPass.Name = "chbPass";
			this.chbPass.Size = new System.Drawing.Size(114, 17);
			this.chbPass.TabIndex = 4;
			this.chbPass.Text = "Показать пароль";
			this.chbPass.UseVisualStyleBackColor = true;
			this.chbPass.CheckedChanged += new System.EventHandler(this.chbPass_CheckedChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(52, 155);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(73, 24);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(178, 189);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.chbPass);
			this.Controls.Add(this.txtbPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbUsers);
			this.Name = "frmLogin";
			this.Text = "Вход";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbUsers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtbPass;
		private System.Windows.Forms.CheckBox chbPass;
		private System.Windows.Forms.Button btnLogin;
	}
}

