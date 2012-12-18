using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taxi1
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		frmLogin log;
		private int _opID;
		int actIndex;

		public int opID
		{
			set {this._opID=value;}
			get {return this._opID;}
		}

		public void setOPID(int value)
		{
			opID = value;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			log = new frmLogin(this);
			log.FormClosed += new FormClosedEventHandler(log_FormClosed);
			this.Visible = false;
			log.ShowDialog();
		}

		void log_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (log.isLogged)
			{
				this.Visible = true;
				lblOP.Text = _opID.ToString();
			}
			else this.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbAction.SelectedIndex != -1) actIndex = cbAction.SelectedIndex;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
				if (actIndex == 0) new frmNewOrder().ShowDialog();
				if (actIndex == 1) new frmAllOrders().ShowDialog();
				if (actIndex == 2) new frmPayments().ShowDialog();
		}
	}
}
