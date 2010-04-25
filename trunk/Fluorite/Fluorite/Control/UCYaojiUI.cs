using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCYaojiUI : Control.UCController
    {
        private String Username = null;

        public UCYaojiUI(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.YaojiUI(this.Username).ShowDialog();
            return true;
        }
    }
}
