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
    /// UC: Creating an instance of CaiwuUI.
    /// </summary>
    class UCCaiwuUI : Control.UCController
    {
        private String Username = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Username">Current username</param>
        public UCCaiwuUI(String Username)
        {
            this.Username = Username;
        }

        /// <summary>
        /// "Execute" inferface.
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwife FALSE.</returns>
        public Boolean Execute()
        {
            new View.CaiwuUI(this.Username).Show();
            return true;
        }
    }
}
