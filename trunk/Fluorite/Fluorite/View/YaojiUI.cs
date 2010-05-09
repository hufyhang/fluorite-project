using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class YaojiUI : Form
    {
        private String Username = null;
        private String IDSQL = @"SELECT charging_id FROM charging_sheet";
        private NumericUpDown CurrentNumber = null;
        private TextBox CurrentText = null;
        private int ControlFlag = 0;

        public YaojiUI(String Username)
        {
            InitializeComponent();

            this.initialEvents();

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.Username = Username;
            this.Text += this.Username;
            this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM charging_sheet_view");
            if (!new Extend.CollectAutoCompleteSource().Execute(this.inputMedicine))
            {
                MessageBox.Show("Extend.CollectAutoCompleteSource组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!new Control.UCMySQLController(@"SELECT material_id FROM material", this.inputD, 0).Execute())
            {
                MessageBox.Show("UCMySQLController组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void initialEvents()
        {
            this.inputMedicine.GotFocus += new EventHandler(inputMedicine_GotFocus);
        }

        protected void inputMedicine_GotFocus(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Refresh();
            this.AnalysisControl(sender);
            this.CurrentText = this.inputMedicine;
        }

        protected void CloseKeyboard()
        {
            this.Width = 638;
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

        private void button1_Click(object sender, EventArgs e)
        {
            String UserID = new Control.UCGetUserID(this.Username).ToString();
            String SQL = @"INSERT INTO charging_sheet VALUES ('" + this.inputSN.Text + @"','" + this.inputMedicine.Text + @"','" + this.inputA.Value.ToString() + @"','" +
                                this.inputB.Value.ToString() + @"','" + this.inputC.Value.ToString() + @"','" + UserID + @"','" + this.inputD.Text + @"')";
            if (new Control.UCMySQLUpdate(SQL).Execute())
            {
                MessageBox.Show("信息记录完成", "操作完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inputA.Value = 0;
                this.inputB.Value = 0;
                this.inputC.Value = 0;
                this.inputSN.Text = new Control.UCGenerateSN(this.IDSQL).ToString();
                this.inputMedicine.Text = "";
            }
            else
            {
                MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = new Model.MySQLModel().CollectFromDatabase(@"SELECT * FROM charging_sheet_view");
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

        private void button3_Click(object sender, EventArgs e)
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

                case "←":
                    this.SelectControl();
                    SendKeys.Send(@"{BKSP}");
                    break;

                case "Space":
                    this.SelectControl();
                    SendKeys.Send(@" ");
                    break;

                case ".":
                    this.SelectControl();
                    SendKeys.Send(@".");
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

        private void inputMedicine_Click(object sender, EventArgs e)
        {
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = true;
        }

    }
}
