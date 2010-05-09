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
    /// UC: To create an instance of GanzaoUI.
    /// </summary>
    class UCGanzaoUI : Control.UCController
    {
        private String Username = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Username">Username</param>
        public UCGanzaoUI(String Username)
        {
            this.Username = Username;
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwise FALSE.</returns>
        public Boolean Execute()
        {
            new View.GanzaoUI(this.Username).Show();
            return true;
        }
    }
}
