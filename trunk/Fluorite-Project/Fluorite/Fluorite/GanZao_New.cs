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
    public partial class GanZao_New : TabPage
    {
        private String databaseAddress = "";

        public GanZao_New(String databaseAddress)
        {
            this.databaseAddress = databaseAddress;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected void reset()
        {
            this.textBox1.Text = "";
            this.numericUpDown1.Value = this.numericUpDown2.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = @"INSERT INTO water_statistics VALUES ('" + this.textBox1.Text + @"','" + this.numericUpDown1.Value.ToString() + @"','" + this.numericUpDown2.Value.ToString() + @"')";
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
