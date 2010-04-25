using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    class UCCheckPassword : Control.UCController
    {
        private String Password = null;
        private String SQL = null;

        public UCCheckPassword(String Username, String Password)
        {
            this.Password = Password;
            this.SQL = "SELECT pwd FROM c_m_user WHERE username='" + Username + "'";
        }

        public Boolean Execute()
        {
            if (this.Password == new Control.UCMySQLController(this.SQL, null, 0).ToString())
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
