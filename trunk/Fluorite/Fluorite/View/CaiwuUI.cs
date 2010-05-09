using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class CaiwuUI : Form
    {
        private String Username = null;
        private String IDSQL = @"SELECT finance_id FROM finance";
        private NumericUpDown CurrentNumber = null;
        private TextBox CurrentText = null;
        private int ControlFlag = 0;

        public CaiwuUI(String Username)
        {
            InitializeComponent();

            this.initialEvents();

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;

            this.Username = Username;
            this.Text += this.Username;
            this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
            new Control.UCMySQLController(@"SELECT ID FROM product", this.inputD, 0).Execute();
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM finance_view");
        }

        protected void initialEvents()
        {
            this.inputName.GotFocus += new EventHandler(inputName_GotFocus);
        }

        protected void inputName_GotFocus(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Refresh();
            this.AnalysisControl(sender);
            this.CurrentText = this.inputName;
        }

        protected void CloseKeyboard()
        {
            this.Width = 640;
            this.Refresh();
            this.groupBox2.Visible = false;
            this.groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!new Control.UCSignOut(this).Execute())
            {
                MessageBox.Show("UCSignOut组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputA_ValueChanged(object sender, EventArgs e)
        {
            this.inputC.Value = this.inputA.Value - this.inputB.Value;
        }

        private void inputC_ValueChanged(object sender, EventArgs e)
        {
            this.inputB.Value = this.inputA.Value - this.inputC.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UserID = new Control.UCGetUserID(this.Username).ToString();
            String SQL = @"INSERT INTO finance VALUES ('" + this.inputSN.Text + @"','" + this.inputName.Text + @"','" +
                    this.inputA.Value.ToString() + @"','" + this.inputB.Value.ToString() + @"','" + this.inputC.Value.ToString() + @"','" + this.inputD.Text + @"','" + UserID + @"')";
            if (new Control.UCMySQLUpdate(SQL).Execute())
            {
                MessageBox.Show("信息记录完成", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
                this.inputName.Text = "";
                this.inputA.Value = this.inputB.Value = this.inputC.Value = 0;
            }
            else
            {
                MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM finance_view");
        }

        #region VKeyboard

        private void button_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "1":
                    this.SelectControl();
                    SendKeys.Send(@"1");
                    break;

                case "2":
                    this.SelectControl();
                    SendKeys.Send(@"2");
                    break;

                case "3":
                    this.SelectControl();
                    SendKeys.Send(@"3");
                    break;

                case "4":
                    this.SelectControl();
                    SendKeys.Send(@"4");
                    break;

                case "5":
                    this.SelectControl();
                    SendKeys.Send(@"5");
                    break;

                case "6":
                    this.SelectControl();
                    SendKeys.Send(@"6");
                    break;

                case "7":
                    this.SelectControl();
                    SendKeys.Send(@"7");
                    break;

                case "8":
                    this.SelectControl();
                    SendKeys.Send(@"8");
                    break;

                case "9":
                    this.SelectControl();
                    SendKeys.Send(@"9");
                    break;

                case "0":
                    this.SelectControl();
                    SendKeys.Send(@"0");
                    break;

                case ".":
                    this.SelectControl();
                    SendKeys.Send(@".");
                    break;

                case "←":
                    this.SelectControl();
                    SendKeys.Send("{BKSP}");
                    break;

                case "A":
                    this.SelectControl();
                    SendKeys.Send(@"a");
                    break;

                case "B":
                    this.SelectControl();
                    SendKeys.Send(@"b");
                    break;

                case "C":
                    this.SelectControl();
                    SendKeys.Send(@"c");
                    break;

                case "D":
                    this.SelectControl();
                    SendKeys.Send(@"d");
                    break;

                case "E":
                    this.SelectControl();
                    SendKeys.Send(@"e");
                    break;

                case "F":
                    this.SelectControl();
                    SendKeys.Send(@"f");
                    break;

                case "G":
                    this.SelectControl();
                    SendKeys.Send(@"g");
                    break;

                case "H":
                    this.SelectControl();
                    SendKeys.Send(@"h");
                    break;

                case "I":
                    this.SelectControl();
                    SendKeys.Send(@"i");
                    break;

                case "J":
                    this.SelectControl();
                    SendKeys.Send(@"j");
                    break;

                case "K":
                    this.SelectControl();
                    SendKeys.Send(@"k");
                    break;

                case "L":
                    this.SelectControl();
                    SendKeys.Send(@"l");
                    break;

                case "M":
                    this.SelectControl();
                    SendKeys.Send(@"m");
                    break;

                case "N":
                    this.SelectControl();
                    SendKeys.Send(@"n");
                    break;

                case "O":
                    this.SelectControl();
                    SendKeys.Send(@"o");
                    break;

                case "P":
                    this.SelectControl();
                    SendKeys.Send(@"p");
                    break;

                case "Q":
                    this.SelectControl();
                    SendKeys.Send(@"q");
                    break;

                case "R":
                    this.SelectControl();
                    SendKeys.Send(@"r");
                    break;

                case "S":
                    this.SelectControl();
                    SendKeys.Send(@"s");
                    break;

                case "T":
                    this.SelectControl();
                    SendKeys.Send(@"t");
                    break;

                case "U":
                    this.SelectControl();
                    SendKeys.Send(@"u");
                    break;

                case "V":
                    this.SelectControl();
                    SendKeys.Send(@"v");
                    break;

                case "W":
                    this.SelectControl();
                    SendKeys.Send(@"w");
                    break;

                case "X":
                    this.SelectControl();
                    SendKeys.Send(@"x");
                    break;

                case "Y":
                    this.SelectControl();
                    SendKeys.Send(@"y");
                    break;

                case "Z":
                    this.SelectControl();
                    SendKeys.Send(@"z");
                    break;

                case "OK":
                    this.CloseKeyboard();
                    break;

                case "Space":
                    this.SelectControl();
                    SendKeys.Send(@" ");
                    break;
            }
        }

        protected void SelectControl()
        {
            try
            {
                switch (this.ControlFlag)
                {
                    case 1:
                        this.CurrentNumber.Select();
                        break;

                    case 2:
                        this.CurrentText.Select();
                        break;

                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        protected void AnalysisControl(object sender)
        {
            if (sender is NumericUpDown)
            {
                this.ControlFlag = 1;
            }
            else if (sender is TextBox)
            {
                this.ControlFlag = 2;
            }
            else
            {
                this.ControlFlag = 0;
            }
        }

        private void inputA_MouseClick(object sender, MouseEventArgs e)
        {
            this.AnalysisControl(sender);
            this.CurrentNumber = this.inputA;
        }

        private void inputB_MouseClick(object sender, MouseEventArgs e)
        {
            this.AnalysisControl(sender);
            this.CurrentNumber = this.inputB;
        }

        private void inputC_MouseClick(object sender, MouseEventArgs e)
        {
            this.AnalysisControl(sender);
            this.CurrentNumber = this.inputC;
        }
        #endregion

        private void inputName_Click(object sender, EventArgs e)
        {
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = true;
        }
    }
}
