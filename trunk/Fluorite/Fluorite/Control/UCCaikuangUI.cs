using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCCaikuangUI : Control.UCController
    {
        private String Username = null;

        public UCCaikuangUI(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.CaikuangUI(this.Username).Show();
            return true;
        }
    }
}
