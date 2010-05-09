/*
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
    /// <summary>
    /// UC: To login.
    /// </summary>
    class UCLogin : Control.UCController
    {
        private int Index = 0;
        private String Username = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Index">Index statement.</param>
        /// <param name="Username">Username statement.</param>
        public UCLogin(int Index, String Username)
        {
            this.Index = Index - 1;
            this.Username = Username;
        }

        /// <summary>
        /// "Execute" interface
        /// </summary>
        /// <returns>Returns TRUE if succeed, otherwise FALSE.</returns>
        public Boolean Execute()
        {
            Boolean result = false;
            switch (this.Index)
            {
                case 0:
                    if (new Control.UCCaikuangUI(this.Username).Execute())
                    {
                        result = true;
                    }
                    break;

                case 1:
                    if (new Control.UCYaojiUI(this.Username).Execute())
                    {
                        result = true;
                    }
                    break;

                case 2:
                    if (new Control.UCGanzaoUI(this.Username).Execute())
                    {
                        result = true;
                    }
                    break;

                case 3:
                    if (new Control.UCYunshuUI(this.Username).Execute())
                    {
                        result = true;
                    }
                    break;

                case 4:
                    if (new Control.UCCaiwuUI(this.Username).Execute())
                    {
                        result = true;
                    }
                    break;
            }

            return result;
        }
    }
}
