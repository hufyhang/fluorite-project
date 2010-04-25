using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCCaiwuUI : Control.UCController
    {
        private String Username = null;

        public UCCaiwuUI(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.CaiwuUI(this.Username).ShowDialog();
            return true;
        }
    }
}
