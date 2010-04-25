using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    class UCCollectWorkGroups : Control.UCController
    {
        private ComboBox workGroupComboBox = null;
        private String SQL = null;

        public UCCollectWorkGroups(String SQL, ComboBox WorkgroupsComboBox)
        {
            this.workGroupComboBox = WorkgroupsComboBox;
            this.SQL = SQL;
        }
        public Boolean Execute()
        {
            this.workGroupComboBox.Items.Clear();
            if (new Control.UCMySQLController(this.SQL, this.workGroupComboBox, 0).Execute())
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
