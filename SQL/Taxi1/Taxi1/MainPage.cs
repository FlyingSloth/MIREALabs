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
		bool isNO, isAO, isAP;

		public int opID;
		/*{
			set {this.opID=value;}
			get {return this.opID;}
		}*/

		public void setOPID(int value)
		{
			opID = value;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSetAllOrders.VIEW_ALL_ORDERS' table. You can move, or remove it, as needed.
			this.vIEW_ALL_ORDERSTableAdapter.Fill(this.dataSetAllOrders.VIEW_ALL_ORDERS);
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
			}
			else this.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TotalSetup()
		{
			if (isNO) NewOrder();
			if (isAO) AllOrders();
			if (isAP) AllPayments();
		}

		private void NewOrder()
		{ 
			
		}

		private void AllOrders()
		{ 
			
		}

		private void AllPayments()
		{ 
			
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			
		}
	}
}
