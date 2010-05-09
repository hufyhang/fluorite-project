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
    /// UC: To generate a serial number, automatically.
    /// </summary>
    class UCGenerateSN : Control.UCController
    {
        private String SQL = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="SQL">SQL statement.</param>
        public UCGenerateSN(String SQL)
        {
            this.SQL = SQL;
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE</returns>
        public Boolean Execute() { return true; }

        /// <summary>
        /// Override "ToString()" interface.
        /// </summary>
        /// <returns>Returns feedbacks.</returns>
        public override string ToString()
        {
            return (int.Parse(new Control.UCMySQLController(this.SQL, null, 0).ToString()) + 1).ToString();
        }
    }
}
