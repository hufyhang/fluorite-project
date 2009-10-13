using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MySQLDriverCS;

namespace Fluorite_Project
{
    public partial class GanZao : Form
    {
        public GanZao()
        {
            InitializeComponent();
        }

        public GanZao(string databaseAddress)
        {
            InitializeComponent();
        }
    }
}
