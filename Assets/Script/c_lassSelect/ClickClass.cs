using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Script;
using UnityEngine;

public class ClickClass : MonoBehaviour
{
    public string c_lass;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        C_lassSelectManager.changeVisual(c_lass);
        
        string sql = "SELECT * FROM charater WHERE name LIKE '" + c_lass + "'";
        MySqlCommand command= new MySqlCommand(sql, DBConnection.getConn());
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();
        Character character = new Character((string)reader["name"],
            (int)reader["maxHealth"],
            (int)reader["maxMana"], null
        );
        reader.Close();

        Player player = GameManager.getGameManager().getPlayer().GetComponent<Player>();
        player.setCharacter(character);
    }
}
