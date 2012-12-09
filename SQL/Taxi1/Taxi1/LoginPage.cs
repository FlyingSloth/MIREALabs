using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Taxi1
{
	public partial class frmLogin : Form
	{
		frmMain _m;
		public frmLogin()
		{
			InitializeComponent();
		}

		
		public frmLogin(frmMain _m)
		{
			InitializeComponent();
			this._m = _m;
			this._m.Visible = false;
		}
		public bool isLogged = false;

		string user;
		string pass;
		string opID;

		string connstring = "User " +
"Id=sloth;Password=12345;Data Source=orcl;";

		OracleConnection conn;
		private void frmLogin_Load(object sender, EventArgs e)
		{
			conn = new OracleConnection(connstring);
			conn.Open();
			string sqluserselect = "SELECT * from users";
			OracleCommand cmduserselectuser = new OracleCommand(sqluserselect, conn);
			cmduserselectuser.CommandType = CommandType.Text;
			OracleDataReader drselectuser = cmduserselectuser.ExecuteReader();

			while (drselectuser.Read())
			{
				cbUsers.Items.Add(drselectuser.GetString(0));
			}
		}

		private void chbPass_CheckedChanged(object sender, EventArgs e)
		{
			if (chbPass.Checked)
			{
				txtbPass.ForeColor = Color.Black;
			}
			else
				txtbPass.ForeColor = Color.White;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (cbUsers.SelectedIndex != -1)
				user = cbUsers.SelectedItem.ToString();
			if (txtbPass.Text.Length != 0) pass = txtbPass.Text;
			else MessageBox.Show("Введите пароль!");
			OracleCommand cmdLogin = new OracleCommand("SLOTH.PR_LOGIN", conn);
			cmdLogin.CommandType = CommandType.StoredProcedure;

			OracleParameter pUser = new OracleParameter();
			pUser.ParameterName = "USERNAME";
			pUser.OracleDbType = OracleDbType.Char;
			pUser.Direction = ParameterDirection.Input;
			pUser.Size = 26;
			pUser.Value = user;
			cmdLogin.Parameters.Add(pUser);

			OracleParameter pPas = new OracleParameter();
			pPas.ParameterName = "PASSWD";
			pPas.OracleDbType = OracleDbType.Char;
			pPas.Direction = ParameterDirection.Output;
			pPas.Size = 30;
			cmdLogin.Parameters.Add(pPas);

			cmdLogin.ExecuteReader();

			if (pPas.Status == OracleParameterStatus.Success)
			{
				string dbpass = pPas.Value.ToString().TrimEnd(' ');
				if (dbpass == pass)
				{
					string sqlID = "SELECT opid from users where (username = '" + user + "') and (pass = '" + pPas.Value.ToString() + "')";
					OracleCommand cmdID = new OracleCommand(sqlID, conn);
					cmdID.CommandType = CommandType.Text;
					OracleDataReader drID = cmdID.ExecuteReader();
					drID.Read();
					opID = drID.GetValue(0).ToString();

					MessageBox.Show("Вход в систему выполнен!");
					isLogged = true;
					_m.opID =  Convert.ToInt32(opID);
					this.Close();
				}
				else
					MessageBox.Show("Неверный логин или пароль!");
			}
		}
	}
}
