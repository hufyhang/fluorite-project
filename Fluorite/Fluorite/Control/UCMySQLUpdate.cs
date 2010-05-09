/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Fluorite.Control
{
    /// <summary>
    /// UC: To update the MySQL.
    /// </summary>
    class UCMySQLUpdate : Control.UCController
    {
        private String SQL = null;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="SQL">SQL statement.</param>
        public UCMySQLUpdate(String SQL)
        {
            this.SQL = SQL;
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwise FALSE.</returns>
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
