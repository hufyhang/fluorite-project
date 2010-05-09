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
    /// <summary>
    /// View: AddValueUI.
    /// </summary>
    public partial class AddValueUI : Form
    {
        private readonly String fileSystem = Application.StartupPath + @"\File System\Plugins";

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AddValueUI()
        {
            InitializeComponent();
            this.LoadPlugins();
        }

        /// <summary>
        /// To load all add-value components from "/File System/Plugins", atutomatically.
        /// </summary>
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

        /// <summary>
        /// To detect and collect executable file for each add-value components.
        /// </summary>
        /// <param name="Dir">Path of specified component.</param>
        /// <returns>Returns path of runnable file.</returns>
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
