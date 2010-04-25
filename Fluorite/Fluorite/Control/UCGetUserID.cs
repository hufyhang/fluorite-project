using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCGetUserID : Control.UCController
    {
        private String Username = null;

        public UCGetUserID(String Username)
        {
            this.Username = Username;
        }

        public Boolean Execute()
        {
            return true;
        }

        public override String ToString()
        {
            String SQL = "SELECT user_id FROM c_m_user WHERE username='" + this.Username + "'";
            return new Control.UCMySQLController(SQL, null, 0).ToString();
        }
    }
}
