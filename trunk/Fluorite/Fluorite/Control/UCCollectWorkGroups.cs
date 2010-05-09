/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    /// <summary>
    /// UC: To get all the user groups from database.
    /// </summary>
    class UCCollectWorkGroups : Control.UCController
    {
        private ComboBox workGroupComboBox = null;
        private String SQL = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="SQL">SQL Statement</param>
        /// <param name="WorkgroupsComboBox">ComboBox control to contain user groups</param>
        public UCCollectWorkGroups(String SQL, ComboBox WorkgroupsComboBox)
        {
            this.workGroupComboBox = WorkgroupsComboBox;
            this.SQL = SQL;
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwise FALSE.</returns>
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
