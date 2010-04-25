using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    class UCGenerateSN : Control.UCController
    {
        private String SQL = null;

        public UCGenerateSN(String SQL)
        {
            this.SQL = SQL;
        }

        public Boolean Execute() { return true; }

        public override string ToString()
        {
            return (int.Parse(new Control.UCMySQLController(this.SQL, null, 0).ToString()) + 1).ToString();
        }
    }
}
