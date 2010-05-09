/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Fluorite.Control
{
    /// <summary>
    /// UC: To control the MySQL.
    /// </summary>
    class UCMySQLController : Control.UCController
    {
        private String SQL;
        private Int32 columnNumber;
        private Object container = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="SQL">SQL statement.</param>
        /// <param name="container">ColumnNumber statement.</param>
        /// <param name="ColumnNumber">Container statement.</param>
        public UCMySQLController(String SQL, Object container, Int32 ColumnNumber)
        {
            this.SQL = SQL;
            this.columnNumber = ColumnNumber;
            this.container = container;
        }

        /// <summary>
        /// "Execute" interface
        /// </summary>
        /// <returns>Returns TRUE if succeed,otherwise FALSE.</returns>
        public Boolean Execute()
        {
            DataTable dataTable = null;
            if ((dataTable = new Model.MySQLModel().CollectFromDatabase(this.SQL)) != null)
            {
                this.InsertIntoContainer(dataTable);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// To insert information to containers.
        /// </summary>
        /// <param name="dataTable">DataTable source.</param>
        protected void InsertIntoContainer(DataTable dataTable)
        {
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (this.container != null)
                {
                    if (this.container is ComboBox)
                    {
                        ((ComboBox)(this.container)).Items.Add(dataRow[this.columnNumber].ToString());
                    }
                    else if (this.container is ListView)
                    {
                        ((ListView)(this.container)).Items.Add(dataRow[this.columnNumber].ToString());
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// To insert information into string.
        /// </summary>
        /// <returns>Returns a string if correct,otherwise null.</returns>
        private String InsetIntoString()
        {
            DataTable dataTable = new Model.MySQLModel().CollectFromDatabase(this.SQL);
            if (dataTable != null)
            {
                return dataTable.Rows[dataTable.Rows.Count - 1][this.columnNumber].ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Override "ToString" interface
        /// </summary>
        /// <returns>Returns a string.</returns>
        public override String ToString()
        {
            return this.InsetIntoString();
        }
    }
}
