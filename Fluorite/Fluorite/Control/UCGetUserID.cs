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
    /// UC: To get ID number of specified user.
    /// </summary>
    class UCGetUserID : Control.UCController
    {
        private String Username = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Username">Username statement.</param>
        public UCGetUserID(String Username)
        {
            this.Username = Username;
        }
        
        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE.</returns>
        public Boolean Execute()
        {
            return true;
        }

        /// <summary>
        /// Override "ToString" interface.
        /// </summary>
        /// <returns>Returns feedbacks.</returns>
        public override String ToString()
        {
            String SQL = "SELECT user_id FROM c_m_user WHERE username='" + this.Username + "'";
            return new Control.UCMySQLController(SQL, null, 0).ToString();
        }
    }
}
