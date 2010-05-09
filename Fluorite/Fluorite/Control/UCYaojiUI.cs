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
    /// UC: To create instance of Yaoji UI.
    /// </summary>
    class UCYaojiUI : Control.UCController
    {
        private String Username = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Username">Username statement.</param>
        public UCYaojiUI(String Username)
        {
            this.Username = Username;
        }

        /// <summary>
        /// "Execute" interface
        /// </summary>
        /// <returns>Returns TRUE.</returns>
        public Boolean Execute()
        {
            new View.YaojiUI(this.Username).Show();
            return true;
        }
    }
}
