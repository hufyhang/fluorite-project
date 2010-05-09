/*
 * Copyright 2009, 2010 HANG Feifei, ZHU Hao, LIAN Ming, FENG Chu
 * 
 * This file is part of Fluorspar Mining Pipeline Working Platform.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySQLDriverCS;

namespace Fluorite.Model
{
    /// <summary>
    /// MySQL Model
    /// </summary>
    class MySQLModel
    {
        private readonly String ConfigurationLocation = Application.StartupPath + @"\Configs\Database";
        private readonly String initializationConfig = "localhost\r\nfluorite\r\nroot\r\nrootroot";
        private String address;
        private String database;
        private String username;
        private String password;

        /// <summary>
        /// Default constructor.
        /// </summary>
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

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="address">Database address</param>
        /// <param name="database">Name of database</param>
        /// <param name="username">Database username</param>
        /// <param name="password">Database password</param>
        public MySQLModel(String address, String database, String username, String password)
        {
            this.address = address;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        /// <summary>
        /// To generate a configuration file, automatically.
        /// </summary>
        /// <param name="configurationFile"></param>
        protected void GenerateConfigration(String configurationFile)
        {
            if (!new FileInfo(configurationFile).Exists)
            {
                StreamWriter write = new StreamWriter(configurationFile);
                write.Write(this.initializationConfig);
                write.Close();
            }
        }

        /// <summary>
        /// To update database.
        /// </summary>
        /// <param name="sql">SQL Statement</param>
        /// <returns>Return TRUE if succeed, otherwife FALSE</returns>
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

        /// <summary>
        /// To collect information/feedback from database.
        /// </summary>
        /// <param name="sql">SQL Statement</param>
        /// <returns>Returns a DataTable</returns>
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
                con.Close();
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
