using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Fluorite
{
    public partial class Startup : Form
    {
        public Startup()
        {
            this.Text = "萤石矿开采管理系统托管程序";
            Form1 login = new Form1();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String databaseAddress = login.getDatabaseAddress();
                switch (login.getLoginStatue())
                {
                    case 1:
                        new FuXuan(databaseAddress).Show();
                        login.Dispose();
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    case 2:
                        new GanZao(databaseAddress).Show();
                        login.Dispose();
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    case 3:
                        new YunShu(databaseAddress).Show();
                        login.Dispose();
                        this.WindowState = FormWindowState.Minimized;
                        break;
                    default:
                        MessageBox.Show("Unkown Error");
                        break;
                }
            }
        }
    }
}
