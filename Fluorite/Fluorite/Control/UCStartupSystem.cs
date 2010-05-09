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
    /// UC: To start up the system.
    /// </summary>
    class UCStartupSystem
    {
        /// <summary>
        /// "Execute" interface
        /// </summary>
        /// <returns>Returns TRUE.</returns>
        public Boolean Execute()
        {
            new View.LoginScreen().ShowDialog();
            return true;
        }
    }
}
