using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCMySQLUpdate : Control.UCController
    {
        private String SQL = null;
        
        public UCMySQLUpdate(String SQL)
        {
            this.SQL = SQL;
        }

        public Boolean Execute()
        {
            if (new Model.MySQLModel().UpdateDatabase(this.SQL))
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
