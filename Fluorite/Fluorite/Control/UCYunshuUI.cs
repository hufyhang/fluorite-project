using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCYunshuUI
    {
        private String Username = null;

        public UCYunshuUI(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.YunshuUI(this.Username).ShowDialog();
            return true;
        }
    }
}
