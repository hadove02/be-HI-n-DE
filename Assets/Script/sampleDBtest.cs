using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UnityEngine;

public class sampleDBtest : MonoBehaviour
{
    private MySqlConnection connection;

    void Start()
    {
    }

    void OnMouseDown()
    {
        connection = DBConnection.getConn();

        string sql = "SELECT * FROM test";
        MySqlCommand cmd = new MySqlCommand(sql, connection);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Debug.Log(reader["aa"] + " " + reader["bb"] + " " + reader["cc"]);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}