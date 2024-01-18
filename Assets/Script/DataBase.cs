using System;
using MySql.Data.MySqlClient;
using UnityEngine;

namespace Script
{
    public class DataBase
    {
        private string server = "127.0.0.1";
        private string port = "3306";
        private string database = "testSchema";
        private string id = "root";
        private string pw = "159633";
        private string connStr;
        private MySqlConnection conn;

        public bool dbConnection()
        {
            string connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                server, port, database, id, pw);
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                 Debug.Log(e.ToString());
                return false;
            }
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
        
    }
}