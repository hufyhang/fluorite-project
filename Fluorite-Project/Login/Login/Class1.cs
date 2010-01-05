using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

using MySQLDriverCS;

namespace Project.DLL
{
    public class Login
    {
        public Boolean passwordCheck(string databaseAddress, string database, String sectionName, string password)
        {
            MySQLConnection con = new MySQLConnection(new MySQLConnectionString(databaseAddress, database, "root", "123456").AsString);
            con.Open();
            String sql = "SELECT pwd FROM class WHERE classname=" + sectionName;
            MySQLCommand command = new MySQLCommand(sql, con);
            MySQLDataReader reader = command.ExecuteReaderEx();
            MySQLDataAdapter adapter = new MySQLDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (password.Equals(table.Rows[0][0].ToString()))
                return true;
            else
                return false;
        }

        public String getSectionName(ComboBox comboBox)
        {
            String name = "";
            switch(comboBox.SelectedIndex)
            {
                case 0:
                    name = "YanMo";
                    break;
                case 1:
                    name = "FuXuan";
                    break;
                case 2:
                    name = "GanZao";
                    break;
                case 3:
                    name = "WeiKuang";
                    break;
                default:
                    name = "YanMo";
                    break;
            }
            return name;
        }
    }
}
