using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySQLDriverCS;

namespace Fluorite.Model
{
    class MySQLModel
    {
        private readonly String ConfigurationLocation = Application.StartupPath + @"\Configs\Database";
        private readonly String initializationConfig = "localhost\r\nfluorite\r\nroot\r\nrootroot";
        private String address;
        private String database;
        private String username;
        private String password;

        public MySQLModel()
        {
            this.GenerateConfigration(this.ConfigurationLocation);
            StreamReader reader = new StreamReader(this.ConfigurationLocation);
            this.address = reader.ReadLine();
            this.database = reader.ReadLine();
            this.username = reader.ReadLine();
            this.password = reader.ReadLine();
            reader.Close();
        }

        public MySQLModel(String address, String database, String username, String password)
        {
            this.address = address;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        protected void GenerateConfigration(String configurationFile)
        {
            if (!new FileInfo(configurationFile).Exists)
            {
                StreamWriter write = new StreamWriter(configurationFile);
                write.Write(this.initializationConfig);
                write.Close();
            }
        }

        public Boolean UpdateDatabase(String sql)
        {
            try
            {
                MySQLConnection con = new MySQLConnection(new MySQLConnectionString(this.address, this.database, this.username, this.password).AsString);
                con.Open();
                MySQLCommand command = new MySQLCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (MySQLException e)
            {
                MessageBox.Show(e.ToString(), "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable CollectFromDatabase(String sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySQLConnection con = new MySQLConnection(new MySQLConnectionString(this.address, this.database, this.username, this.password).AsString);
                con.Open();
                MySQLCommand command = new MySQLCommand(sql, con);
                MySQLDataReader reader = command.ExecuteReaderEx();
                MySQLDataAdapter adapter = new MySQLDataAdapter(sql, con);
                adapter.Fill(dataTable);
            }
            catch (MySQLException e)
            {
                MessageBox.Show(e.ToString(), "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataTable = null;
            }
            return dataTable;
        }
    }
}
