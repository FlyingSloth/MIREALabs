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
	public partial class frmAllOrders : Form
	{
		public frmAllOrders()
		{
			InitializeComponent();
		}

		string connstring = "User " +
"Id=sloth;Password=12345;Data Source=orcl;";

		OracleConnection conn;

		private void AllOrders_Load(object sender, EventArgs e)
		{
			conn = new OracleConnection(connstring);
			
			getAllOrders();
		}

		private void getAllOrders()
		{
			grdvOrders.DataSource = null;
			conn.Open();
			string sqlSelectAllOrders = "Select orders.orderid, torder.address, cartype.type, car.color, torder.arrivaltime, state.state from orders, torder, cartype, car, state" +
				" where torder.id = orders.orderid and car.carid = torder.carid and cartype.id = car.typeid and state.id = orders.state";

			OracleCommand cmdSelectAllOrders = new OracleCommand(sqlSelectAllOrders, conn);
			cmdSelectAllOrders.CommandType = CommandType.Text;

			DataSet ds = new DataSet();
			ds.Locale = System.Globalization.CultureInfo.InvariantCulture;
			OracleDataAdapter ad = new OracleDataAdapter(cmdSelectAllOrders);
			ad.Fill(ds);
			ds.Tables[0].Columns[0].ColumnName = "Номер заказа";
			ds.Tables[0].Columns[1].ColumnName = "Адрес заказчика";
			ds.Tables[0].Columns[2].ColumnName = "Марка машины";
			ds.Tables[0].Columns[3].ColumnName = "Цвет машины";
			ds.Tables[0].Columns[4].ColumnName = "Время выполнения заказа";
			ds.Tables[0].Columns[5].ColumnName = "Статус заказа";
			grdvOrders.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void getFinishedOrders()
		{
			grdvOrders.DataSource = null;
			conn.Open();
			string sqlSelectFOrders = "Select orders.orderid, torder.address, cartype.type, car.color, torder.arrivaltime from orders, torder, cartype, car" +
				" where torder.id = orders.orderid and car.carid = torder.carid and cartype.id = car.typeid and orders.state = '1'";

			OracleCommand cmdSelectFOrders = new OracleCommand(sqlSelectFOrders, conn);
			cmdSelectFOrders.CommandType = CommandType.Text;

			DataSet ds = new DataSet();
			ds.Locale = System.Globalization.CultureInfo.InvariantCulture;
			OracleDataAdapter ad = new OracleDataAdapter(cmdSelectFOrders);
			ad.Fill(ds);
			ds.Tables[0].Columns[0].ColumnName = "Номер заказа";
			ds.Tables[0].Columns[1].ColumnName = "Адрес заказчика";
			ds.Tables[0].Columns[2].ColumnName = "Марка машины";
			ds.Tables[0].Columns[3].ColumnName = "Цвет машины";
			ds.Tables[0].Columns[4].ColumnName = "Время выполнения заказа";
			grdvOrders.DataSource = ds.Tables[0];
			conn.Close();
			grdvOrders.Update();
		}

		private void rbFinished_CheckedChanged(object sender, EventArgs e)
		{
			if (rbFinished.Checked) getFinishedOrders();
		}

		private void rbAllOrders_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAllOrders.Checked) getAllOrders();
		}
	}
}
