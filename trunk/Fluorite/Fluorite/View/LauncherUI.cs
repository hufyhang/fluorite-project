using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class LauncherUI : Form
    {
        private String path = null;

        public LauncherUI(String Path)
        {
            InitializeComponent();
            this.initialEvents();
            this.path = Path;
        }

        protected void initialEvents()
        {
            foreach (Object obj in this.groupBox1.Controls)
            {
                if (obj is PictureBox)
                {
                    ((PictureBox)obj).MouseEnter += new EventHandler(icon_MouseOn);
                    ((PictureBox)obj).MouseLeave += new EventHandler(icon_MouseLeave);
                }
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

        private void picviewerIcon_Click(object sender, EventArgs e)
        {
            new View.PictureViewerUI(this.path, true).Show();
            this.Dispose();
        }

        private void movIcon_Click(object sender, EventArgs e)
        {
            new View.MediaPlayerUI(this.path).Show();
            this.Dispose();
        }

        private void notepadIcon_Click(object sender, EventArgs e)
        {
            new View.NotepadUI(this.path, true).Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
