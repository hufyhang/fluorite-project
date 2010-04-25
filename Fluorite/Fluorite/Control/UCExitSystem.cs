using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    class UCExitSystem : Control.UCController
    {
        public Boolean Execute()
        {
            Application.Exit();
            return true;
        }
    }
}
