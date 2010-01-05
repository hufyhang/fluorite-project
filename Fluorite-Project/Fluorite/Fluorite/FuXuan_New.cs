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
    public partial class FuXuan_New : TabPage
    {
        private String databaseAddress = "";

        public FuXuan_New(String databaseAddress)
        {
            InitializeComponent();
            this.databaseAddress = databaseAddress;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        protected void reset()
        {
            this.textBox1.Text = "";
            this.comboBox1.Text = "A";
            this.numericUpDown1.Value = this.numericUpDown2.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = @"INSERT INTO charging_sheet VALUES ('" + this.textBox1.Text + @"','" + this.comboBox1.Text + @"','" + 
                this.numericUpDown1.Value.ToString() + @"','" + this.numericUpDown2.Value.ToString() + @"')";
            MySQLConnection con = new MySQLConnection(new MySQLConnectionString(this.databaseAddress, "fluorite", "root", "123456").AsString);
            con.Open();
            MySQLCommand command = new MySQLCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("讯息登录完成", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.reset();
        }
    }
}
