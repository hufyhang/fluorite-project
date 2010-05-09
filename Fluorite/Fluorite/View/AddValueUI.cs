using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class AddValueUI : Form
    {
        private readonly String fileSystem = Application.StartupPath + @"\File System\Plugins";

        public AddValueUI()
        {
            InitializeComponent();
            this.LoadPlugins();
        }

        protected void LoadPlugins()
        {
            int index = 0;
            this.listView1.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(this.fileSystem);
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                ListViewItem item = new ListViewItem((++index).ToString());
                item.SubItems.Add(dir.Name);
                item.SubItems.Add(this.GetExecutable(dir));
                this.listView1.Items.Add(item);
            }
            this.toolStripStatusLabel2.Text = index.ToString();
        }

        protected String GetExecutable(DirectoryInfo Dir)
        {
            String answer = "";
            foreach (FileInfo file in Dir.GetFiles())
            {
                if (file.Extension.ToUpper().ToString() == @".EXE")
                {
                    answer = file.FullName;
                    break;
                }
            }
            return answer;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                System.Diagnostics.Process.Start(this.listView1.SelectedItems[0].SubItems[2].Text);
                this.Dispose();
            }
        }
    }
}
