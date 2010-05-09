using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCGanzaoUI : Control.UCController
    {
        private String Username = null;

        public UCGanzaoUI(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.GanzaoUI(this.Username).Show();
            return true;
        }
    }
}
