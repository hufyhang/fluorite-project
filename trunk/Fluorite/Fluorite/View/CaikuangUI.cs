using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class CaikuangUI : Form
    {
        private String Username = null;
        private String IDSQL = @"SELECT material_id FROM material";
        private NumericUpDown CurrentNumber = null;

        public CaikuangUI()
        {
            InitializeComponent();
        }

        public CaikuangUI(String Username)
        {
            InitializeComponent();
            this.InputDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Username = Username;
            this.Text += this.Username;
            this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM material");
        }

        protected void SelectControl()
        {
            try
            {
                this.CurrentNumber.Select();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!new Control.UCSignOut(this).Execute())
            {
                MessageBox.Show("UCSignOut组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UserID = new Control.UCGetUserID(this.Username).ToString();
            String SQL = @"INSERT INTO material VALUES ('" + this.inputSN.Text + @"','" + this.InputDateTime.Text + @"','" +
                    this.inputA.Value.ToString() + @"','" + UserID + @"')";
            if (new Control.UCMySQLUpdate(SQL).Execute())
            {
                MessageBox.Show("信息记录完成", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputA.Value = 0;
                this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
            }
            else
            {
                MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM material");
        }

        #region VKeyboard

        private void button11_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@".");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send("{BKSP}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"1");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"9");
        }
        #endregion

        private void inputA_MouseClick(object sender, MouseEventArgs e)
        {
            this.CurrentNumber = this.inputA;
        }
    }
}
