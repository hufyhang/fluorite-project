using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCStartupSystem
    {
        public Boolean Execute()
        {
            new View.LoginScreen().ShowDialog();
            return true;
        }
    }
}
