using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    class UCSignOut : Control.UCController
    {
        private Form ViewScreen = null;

        public UCSignOut(Form ViewScreen)
        {
            this.ViewScreen = ViewScreen;
        }

        public Boolean Execute()
        {
            this.ViewScreen.Dispose();
            if (new Control.UCStartupSystem().Execute())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
