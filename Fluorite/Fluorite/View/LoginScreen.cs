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
        public LoginScreen()
        {
            InitializeComponent();

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
                if (new Control.UCLogin(int.Parse(new Control.UCMySQLController(SQL, null, 0).ToString()), this.inputUsername.Text).Execute())
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
    }
}
