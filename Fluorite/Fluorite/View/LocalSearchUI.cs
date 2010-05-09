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
    public partial class LocalSearchUI : Form
    {
        private String Item = null;
        private BeginToSearch DoSearch;

        public LocalSearchUI(String Item)
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.Item = Item;
            this.Text += @" - " + this.Item;
            this.DoSearch = new BeginToSearch(this.Search);
            this.DoSearch.BeginInvoke(Application.StartupPath + @"\File System", null, null);
        }

        protected delegate void BeginToSearch(String path);
        protected void Search(String path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            foreach(DirectoryInfo dir in dirInfo.GetDirectories())
            {
                this.toolStripStatusLabel1.Text = dir.FullName;
                this.Search(dir.FullName);
            }
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                this.toolStripStatusLabel1.Text = file.FullName;
                if (file.Name.ToUpper().Contains(this.Item.ToUpper()))
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.DirectoryName);
                    this.listView1.Items.Add(item);
                }
            }
            this.toolStripStatusLabel1.Text = "搜索完成 --  搜索到 " + this.listView1.Items.Count.ToString() + " 项文件。";
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                String path = this.listView1.SelectedItems[0].SubItems[2].Text + @"\" + this.listView1.SelectedItems[0].SubItems[0].Text;
                new View.LauncherUI(path).Show();
            }
        }
    }
}
