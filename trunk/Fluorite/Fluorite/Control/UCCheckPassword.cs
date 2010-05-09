/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Fluorite.Control
{
    /// <summary>
    /// To check whether the password entered is correct.
    /// </summary>
    class UCCheckPassword : Control.UCController
    {
        private String Password = null;
        private String SQL = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Username">Inputted username</param>
        /// <param name="Password">Inputted password</param>
        public UCCheckPassword(String Username, String Password)
        {
            this.Password = Password;
            this.SQL = "SELECT pwd FROM c_m_user WHERE username='" + Username + "'";
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE if corrected, otherwife FALSE.</returns>
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
