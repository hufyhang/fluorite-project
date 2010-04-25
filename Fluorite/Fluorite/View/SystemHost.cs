using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.View
{
    public partial class SystemHost : Form
    {
        public SystemHost()
        {
            InitializeComponent();
            new Control.UCStartupSystem().Execute();
        }
    }
}
