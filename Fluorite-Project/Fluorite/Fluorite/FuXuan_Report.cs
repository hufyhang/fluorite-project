using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;

namespace Fluorite
{
    public partial class FuXuan_Report : TabPage
    {
        private String databaseAddress = "";

        public FuXuan_Report(String databaseAddress)
        {
            this.databaseAddress = databaseAddress;
            InitializeComponent();
            this.Text = "工作简报";
            loadReports();
        }

        protected void loadReports()
        {
            MySQLConnection con = new MySQLConnection(new MySQLConnectionString(this.databaseAddress, "fluorite", "root", "123456").AsString);
            con.Open();
            String sql = "SELECT * FROM charging_sheet";
            MySQLCommand command = new MySQLCommand(sql, con);
            MySQLDataReader reader = command.ExecuteReaderEx();
            MySQLDataAdapter adapter = new MySQLDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "charging_sheet");
            this.dataGridView1.DataSource = dataSet.Tables["charging_sheet"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
