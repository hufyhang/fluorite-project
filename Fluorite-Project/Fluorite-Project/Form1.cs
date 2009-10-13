using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using Project.DLLs;
using MySQLDriverCS;

namespace Fluorite_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseAddressInitial();
        }

        protected void DatabaseAddressInitial()
        {
            Project.DLLs.Login databaseAddress = new Login();
            databaseAddress.DatabaseAddressInitial(this.textBoxX1);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void login_mode(int sectionIndex, int groupIndex)
        {
            if (this.comboBoxEx2.Text.Equals("工作组..."))
            {
                MessageBox.Show("登录信息错误，请重新选择登录信息", "登录信息错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Project.DLLs.Login checker = new Login();
            switch (sectionIndex)
            {
                case 0:
                    if (checker.passwordCheck(this.textBoxX1.Text, "mining_system", sectionIndex, groupIndex, this.maskedTextBoxAdv1.Text))
                    {
                        this.Visible = false;
                        YanMo yanmo = new YanMo(this.textBoxX1.Text);
                        yanmo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "登录信息错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 1:
                    if (checker.passwordCheck(this.textBoxX1.Text, "mining_system", sectionIndex, groupIndex, this.maskedTextBoxAdv1.Text))
                    {
                        this.Visible = false;
                        FuXuan fuxuan = new FuXuan(this.textBoxX1.Text);
                        fuxuan.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "登录信息错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2:
                    if (checker.passwordCheck(this.textBoxX1.Text, "mining_system", sectionIndex, groupIndex, this.maskedTextBoxAdv1.Text))
                    {
                        this.Visible = false;
                        GanZao ganzao = new GanZao(this.textBoxX1.Text);
                        ganzao.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "登录信息错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3:
                    if (checker.passwordCheck(this.textBoxX1.Text, "mining_system", sectionIndex, groupIndex, this.maskedTextBoxAdv1.Text))
                    {
                        this.Visible = false;
                        WeiKuang weikuang = new WeiKuang(this.textBoxX1.Text);
                        weikuang.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "登录信息错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("登录信息未选择", "登录信息错误", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Project.DLLs.Login update = new Login();
            update.DatabaseAddressUpdate(this.textBoxX1.Text);

            MessageBox.Show("数据库服务器地址更新保存完毕", "数据库服务器地址更新",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (this.maskedTextBoxAdv1.Text == "")
            {
                MessageBox.Show("登录密码未填写", "登录信息错误",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                login_mode(this.comboBoxEx1.SelectedIndex, this.comboBoxEx2.SelectedIndex);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project.DLLs.Login login = new Login();
            login.UserGroupsUpdate(this.comboBoxEx2, this.comboBoxEx1.SelectedIndex);
        }
    }
}
