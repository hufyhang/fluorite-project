using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class HomeScreenUI : Form
    {
        private String Username = null;
        private int UserIndex = 0;
        private String lastMessage = "";
        private readonly String AnnounceConfig = Application.StartupPath + @"\Configs\AnnounceConfig";
        private readonly String AnnouceFile = null;

        public HomeScreenUI(int UserIndex, String Username)
        {
            InitializeComponent();
            this.initialEvents();
            this.AnnouceFile = this.GetAnnounceAddress(this.AnnounceConfig);
            this.Username = Username;
            this.labelUsername.Text = @"当前用户: " + this.Username;
            this.UserIndex = UserIndex;
            this.loadAnnouncement();
        }

        protected String GetAnnounceAddress(String path)
        {
            StreamReader reader = new StreamReader(path);
            String str = reader.ReadLine();
            reader.Close();
            return str;
        }

        protected void initialEvents()
        {
            this.panel1.Height = 0;
            foreach (Object obj in this.Controls)
            {
                if (obj is PictureBox)
                {
                    ((PictureBox)obj).MouseEnter += new EventHandler(icon_MouseOn);
                    ((PictureBox)obj).MouseLeave += new EventHandler(icon_MouseLeave);
                }
            }

            this.labelMessage.GotFocus += new EventHandler(labelMessage_GotFocus);
            this.labelMessage.LostFocus += new EventHandler(labelMessage_LostFocus);
        }

        protected void labelMessage_GotFocus(object sender, EventArgs e)
        {
            this.labelMessage.BackAlpha = 90;
        }

        protected void labelMessage_LostFocus(object sender, EventArgs e)
        {
            this.labelMessage.BackAlpha = 30;
        }

        protected void loadAnnouncement()
        {
            StreamReader reader = new StreamReader(this.AnnouceFile, System.Text.Encoding.Default);
            this.labelAnnouncement.Text = reader.ReadToEnd();
            reader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelDateTime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            if (this.panel2.Visible)
            {
                this.buttonSystem.Text = @"↓";
                this.panel2.Visible = false;
            }
            else
            {
                this.buttonSystem.Text = @"↑";
                this.panel2.Visible = true;
            }
        }

        protected void icon_DoubleClick(object sender, EventArgs e)
        {
            if (!new Control.UCIconLaunch(this.UserIndex, this.Username, ((PictureBox)sender).Name).Execute())
            {
                MessageBox.Show("UCIconLaunch组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void icon_MouseOn(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(83, 85);
        }

        protected void icon_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(73, 75);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.panel1.Height >= 35)
            {
                this.timer2.Enabled = false;
            }
            else
            {
                this.panel1.Height += 5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new View.LocalSearchUI(this.textBoxX1.Text).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!new Control.UCSignOut(this).Execute())
            {
                MessageBox.Show("UCSignOut组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            String message = "\r\n\r\n";
            message += new Control.UCMySQLController(@"SELECT * FROM publisher_view", null, 0).ToString()  + " (" + 
                                new Control.UCMySQLController(@"SELECT * FROM publisher_view", null, 2).ToString() + ") --\r\n" + 
                                new Control.UCMySQLController(@"SELECT * FROM publisher_view", null, 1).ToString();
            if (message != this.lastMessage)
            {
                this.labelMessage.AppendText(message);
                this.lastMessage = message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBoxMessage.Text.Length != 0)
            {
                String SQL = @"INSERT INTO message VALUES ('" + DateTime.Now.ToLocalTime().ToString() + @"','" + this.textBoxMessage.Text + @"','" + this.UserIndex + @"')";
                if (new Control.UCMySQLUpdate(SQL).Execute())
                {
                    this.textBoxMessage.Text = "";
                }
                else
                {
                    MessageBox.Show("UCMySQLUpdate组件错误", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timerAnnouncement_Tick(object sender, EventArgs e)
        {
            this.loadAnnouncement();
        }
    }
}
