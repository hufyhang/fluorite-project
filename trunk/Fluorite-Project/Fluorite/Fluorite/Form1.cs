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
    public partial class Form1 : Form
    {
        private String databaseAddress = "";
        private int loginStatue = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordCheck(this.textBox1.Text, "fluorite",  getSectionID(this.comboBox1), this.textBox2.Text);
        }

        public String getDatabaseAddress()
        {
            return this.databaseAddress;
        }

        protected void passwordCheck(string databaseAddress, string database, String sectionID, string password)
        {
            MySQLConnection con = new MySQLConnection(new MySQLConnectionString(databaseAddress, database, "root", "123456").AsString);
            con.Open();
            String sql = "SELECT pwd FROM class WHERE class_id=" + sectionID.ToString();
            MySQLCommand command = new MySQLCommand(sql, con);
            MySQLDataReader reader = command.ExecuteReaderEx();
            MySQLDataAdapter adapter = new MySQLDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (password.Equals(table.Rows[0][0].ToString()))
            {
                this.databaseAddress = databaseAddress;
                this.DialogResult = DialogResult.OK;
                this.loginStatue = int.Parse(sectionID);
            }
            else
            {
                MessageBox.Show("非法的登录讯息，请重新确认后再次尝试登入。", "登录讯息警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.comboBox1.SelectedIndex = 0;
                this.textBox2.Text = "";
            }
        }

        public int getLoginStatue()
        {
            return this.loginStatue;
        }

        protected String getSectionID(ComboBox comboBox)
        {
            String name = "";
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    name = "1";
                    break;
                case 1:
                    name = "2";
                    break;
                case 2:
                    name = "3";
                    break;
                default:
                    name = "1";
                    break;
            }
            return name;
        }
    }
}
