using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class LoginScreen : Form
    {
        private TextBox currentText = null;

        public LoginScreen()
        {
            InitializeComponent();
            this.groupBox1.Visible = false;
            this.CollectWorkGroups();
        }

        protected void CollectWorkGroups()
        {
            String SQL = @"SELECT department_name FROM department";
            if (!new Control.UCCollectWorkGroups(SQL, this.inputWorkGroup).Execute())
            {
                MessageBox.Show("数据库信息读取错误！");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            new Control.UCExitSystem().Execute();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (new Control.UCCheckPassword(this.inputUsername.Text, this.inputPassword.Text).Execute())
            {
                String SQL = @"SELECT department_id FROM c_m_user WHERE username='" + this.inputUsername.Text + @"'";
                if (new Control.UCDesktop(int.Parse(new Control.UCMySQLController(SQL, null, 0).ToString()), this.inputUsername.Text).Execute())
                {
                    this.inputUsername.Text = this.inputPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("系统错误，无法登陆！", "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("登录密码错误，请重新输入！", "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.inputPassword.Text = this.inputUsername.Text = "";
            }
        }

        private void inputUsername_MouseClick(object sender, MouseEventArgs e)
        {
            this.currentText = this.inputUsername;
        }

        private void inputPassword_MouseClick(object sender, MouseEventArgs e)
        {
            this.currentText = this.inputPassword;
        }

        protected void SelectControl()
        {
            try
            {
                this.currentText.Select();
            }
            catch (NullReferenceException)
            {
            }
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

                case ".":
                    this.SelectControl();
                    SendKeys.Send(@".");
                    break;

                case "←":
                    this.SelectControl();
                    SendKeys.Send(@"{BKSP}");
                    break;

                case "Space":
                    this.SelectControl();
                    SendKeys.Send(@" ");
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.groupBox1.Visible)
            {
                this.groupBox1.Visible = false;
                this.panel1.Location = new Point(this.panel1.Location.X, this.panel1.Location.Y + this.groupBox1.Height - 10);
            }
            else
            {
                this.groupBox1.Visible = true;
                this.panel1.Location = new Point(this.panel1.Location.X, this.panel1.Location.Y - this.groupBox1.Height + 10);
            }
        }

    }
}
