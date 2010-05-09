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
    /// UC: Creating an instance of CaikuangUI.
    /// </summary>
    class UCCaikuangUI : Control.UCController
    {
        private String Username = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Username">Current Username</param>
        public UCCaikuangUI(String Username)
        {
            this.Username = Username;
        }

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwife FALSE.</returns>
        public Boolean Execute()
        {
            new View.CaikuangUI(this.Username).Show();
            return true;
        }
    }
}
