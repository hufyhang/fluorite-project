﻿/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Fluorite.Control
{
    class UCDesktop : Control.UCController
    {
        private int Index = 0;
        private String Username = null;

        public UCDesktop(int Index, String Username)
        {
            this.Index = Index;
            this.Username = Username;
        }

        public Boolean Execute()
        {
            new View.HomeScreenUI(this.Index, this.Username).ShowDialog();
            return true;
        }
    }
}
