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
    /// UC: To sign out.
    /// </summary>
    class UCSignOut : Control.UCController
    {
        private Form ViewScreen = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ViewScreen">ViewScreen statement.</param>
        public UCSignOut(Form ViewScreen)
        {
            this.ViewScreen = ViewScreen;
        }

        /// <summary>
        /// "Execute" interface
        /// </summary>
        /// <returns>Returns TRUE.</returns>
        public Boolean Execute()
        {
            this.ViewScreen.Dispose();
            return true;
        }
    }
}
