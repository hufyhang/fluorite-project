using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class YunshuUI : Form
    {
        private String Username = null;
        private String PACKIDSQL = @"SELECT pack_id FROM pack";
        private String PRODUCTIDSQL = @"SELECT ID FROM product";
        private NumericUpDown CurrentNumber = null;

        public YunshuUI(String Username)
        {
            InitializeComponent();
            this.inputPackDateTime.CustomFormat = this.inputProductDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Username = Username;
            this.Text += this.Username;
            this.initialComboBox();
            this.inputPackSN.Text = new Control.UCGenerateSN(this.PACKIDSQL).ToString();
            this.inputProductSN.Text = new Control.UCGenerateSN(this.PRODUCTIDSQL).ToString();
            this.dataGridViewPack.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM pack");
            this.dataGridViewProduct.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM product");
        }

        protected void initialComboBox()
        {
            String SQL = @"SELECT charging_id FROM charging_sheet";
            if (!new Control.UCCollectWorkGroups(SQL, this.inputA).Execute())
            {
                MessageBox.Show("数据库 charging_sheet 信息读取错误！");
            }

            SQL = @"SELECT water_id FROM water_statistics";
            if (!new Control.UCCollectWorkGroups(SQL, this.inputB).Execute())
            {
                MessageBox.Show("数据库 water_statistics 信息读取错误！");
            }

            SQL = @"SELECT pack_id FROM pack";
            if (!new Control.UCCollectWorkGroups(SQL, this.inputC).Execute())
            {
                MessageBox.Show("数据库 pack 信息读取错误！");
            }

            SQL = @"SELECT material_id FROM material";
            if (!new Control.UCCollectWorkGroups(SQL, this.inputD).Execute())
            {
                MessageBox.Show("数据库 material 信息读取错误！");
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
            String SQL = @"INSERT INTO pack VALUES ('" + this.inputPackSN.Text + @"','" + this.inputPackDateTime.Text + @"','" +
                    this.inputPackWeight.Value.ToString() + @"','" + UserID + @"')";
            if (new Control.UCMySQLUpdate(SQL).Execute())
            {
                MessageBox.Show("信息记录完成", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputPackSN.Text = new Control.UCGenerateSN(this.PACKIDSQL).ToString();
                this.inputPackWeight.Value = 0;
            }
            else
            {
                MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String UserID = new Control.UCGetUserID(this.Username).ToString();
            String SQL = @"INSERT INTO product VALUES ('" + this.inputProductSN.Text + @"','" + this.inputProductDateTime.Text + @"','" + UserID + @"','" +
                                this.inputA.Text + @"','" + this.inputB.Text + @"','" + this.inputC.Text + @"','" + this.inputD.Text + @"')";
            if (new Control.UCMySQLUpdate(SQL).Execute())
            {
                MessageBox.Show("信息记录完成", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputProductSN.Text = new Control.UCGenerateSN(this.PRODUCTIDSQL).ToString();
                this.inputA.Text = "";
                this.inputB.Text = "";
                this.inputC.Text = "";
                this.inputD.Text = "";
            }
            else
            {
                MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataGridViewPack.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM pack");
            this.dataGridViewProduct.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM product");
        }

        #region VKeyboard

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

        private void inputPackWeight_MouseClick(object sender, MouseEventArgs e)
        {
            this.CurrentNumber = this.inputPackWeight;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@".");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send("{BKSP}");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.SelectControl();
            SendKeys.Send(@"1");
        }

        private void button13_Click(object sender, EventArgs e)
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
    }
}
