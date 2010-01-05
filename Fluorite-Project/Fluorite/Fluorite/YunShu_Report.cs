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
    public partial class YunShu_Report : TabPage
    {
        private String databaseAddress = "";

        public YunShu_Report(String databaseAddress)
        {
            this.databaseAddress = databaseAddress;
            InitializeComponent();
            loadReport();
        }

        protected void loadReport()
        {
            MySQLConnection con = new MySQLConnection(new MySQLConnectionString(this.databaseAddress, "fluorite", "root", "123456").AsString);
            con.Open();
            String sql = "SELECT * FROM package";
            MySQLCommand command = new MySQLCommand(sql, con);
            MySQLDataReader reader = command.ExecuteReaderEx();
            MySQLDataAdapter adapter = new MySQLDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "package");
            this.dataGridView1.DataSource = dataSet.Tables["package"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
