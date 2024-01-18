using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Send : MonoBehaviour
{
    private static string sendStr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log(sendStr);
        string sql = "SELECT * FROM stat WHERE name LIKE '" + sendStr + "'";
        MySqlCommand command= new MySqlCommand(sql, DBConnection.getConn());
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        Stat stat = new Stat((int)reader["atk"],
            (int)reader["def"],
            (int)reader["spd"]
        );
        Player.setStat(stat);
        reader.Close();
    }
    
    public static void setStr(string str)
    {
        sendStr = str;
    }
}
