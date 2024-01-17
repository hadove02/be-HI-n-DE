using System;
using MySql.Data.MySqlClient;
using Script;
using UnityEngine;

public class DBConnection : MonoBehaviour
{
    private static DBConnection dbConn; 
    private static DataBase db;

    void Start()
    {
        db = new DataBase();
        
        if (dbConn == null)
        {
            dbConn = this;
        }

        if (db.dbConnection())
        {
            Debug.Log("connect");
        }
        else
        {
            Debug.Log("failed");
        }
    }

    public static DBConnection getDBConn()
    {
        return dbConn;
    }

    public static MySqlConnection getConn()
    {
        return db.getConn();
    }
}