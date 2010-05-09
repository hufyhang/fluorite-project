/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Fluorite.Extend
{
    /// <summary>
    /// To collect auto complete source.
    /// </summary>
    class CollectAutoCompleteSource
    {
        private readonly String File = Application.StartupPath + @"\Configs\Source";

        /// <summary>
        /// "Execute" interface.
        /// </summary>
        /// <param name="textBox">The TextBox control to contain Auto Complete Source</param>
        /// <returns>Returns TRUE if succeed, otherwise FALSE</returns>
        public Boolean Execute(TextBox textBox)
        {
            Boolean result = false;
            try
            {
                AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
                String line = null;
                StreamReader reader = new StreamReader(this.File);
                while ((line = reader.ReadLine()) != null)
                {
                    stringCollection.Add(line);
                }
                reader.Close();
                textBox.AutoCompleteCustomSource = stringCollection;
                result = true;
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Configs/Source 文件缺失", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
