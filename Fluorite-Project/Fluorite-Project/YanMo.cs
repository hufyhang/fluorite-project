using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using MySQLDriverCS;

namespace Fluorite_Project
{
    public partial class YanMo : Form
    {
        public YanMo()
        {
            InitializeComponent();
        }

        public YanMo(string database)
        {
            InitializeComponent();
        }
    }
}
