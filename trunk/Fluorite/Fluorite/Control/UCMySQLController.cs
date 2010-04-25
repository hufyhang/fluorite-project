using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Fluorite.Control
{
    class UCMySQLController : Control.UCController
    {
        private String SQL;
        private Int32 columnNumber;
        private Object container = null;

        public UCMySQLController(String SQL, Object container, Int32 ColumnNumber)
        {
            this.SQL = SQL;
            this.columnNumber = ColumnNumber;
            this.container = container;
        }

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

        public override String ToString()
        {
            return this.InsetIntoString();
        }
    }
}
