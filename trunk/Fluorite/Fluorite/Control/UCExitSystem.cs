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
    /// UC: To exit from system.
    /// </summary>
    class UCExitSystem : Control.UCController
    {

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <returns>Return TRUE after exit.</returns>
        public Boolean Execute()
        {
            Application.Exit();
            return true;
        }
    }
}
