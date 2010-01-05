using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite
{
    public partial class FuXuan : Form
    {
        private String databaseAddress = "";

        public FuXuan(String databaseAddress)
        {
            this.databaseAddress = databaseAddress;
            InitializeComponent();
            initialEvents();
        }

        protected void initialEvents()
        {
            this.listView1.DoubleClick += new EventHandler(listView1_DoubleClick);
        }

        protected void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                switch (this.listView1.SelectedIndices[0])
                {
                    case 0:
                        this.tabControl1.Controls.Add(new FuXuan_New(this.databaseAddress));
                        break;
                    case 1:
                        this.tabControl1.Controls.Add(new FuXuan_Report(this.databaseAddress));
                        break;
                }
                this.tabControl1.SelectedIndex = this.tabControl1.TabCount - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否需要现在登出系统？", "登出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
