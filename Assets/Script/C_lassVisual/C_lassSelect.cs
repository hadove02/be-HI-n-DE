using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Script;
using UnityEngine;

public class C_lassSelect : MonoBehaviour
{
    public string c_lass;
    
    void OnMouseDown()
    {
        string sql = "SELECT * FROM charater WHERE name LIKE '" + c_lass + "'";
        MySqlConnection connection = DBConnection.getConn();
        MySqlCommand command = new MySqlCommand(sql, connection);
        MySqlDataReader reader = command.ExecuteReader();
        reader.Read();

        Charater charater = new Charater(
            (string)reader["name"],
            (int)reader["maxMana"],
            (int)reader["maxHealth"]
        );
        reader.Close();
        
        sql = "SELECT skill_name,is_passive,damage,cost_mana " +
              "FROM skill JOIN charater ON skill.c_lass = charater.charater_num " +
              "WHERE name LIKE '" + c_lass + "'";
        command = new MySqlCommand(sql, connection);
        reader = command.ExecuteReader();
        Skill[] skills = new Skill[4];
        int i = 0;
        while (reader.Read())
        {
            Skill skill = new Skill(
                (string)reader["skill_name"],
                (bool)reader["is_passive"],
                (int)reader["damage"],
                (int)reader["cost_mana"]);
            skills[i++] = skill;
        }
        reader.Close();
        GameManager.getGameManager().setPlayerC_lass(charater);
        GameManager.getGameManager().setSkills(skills);
        C_lassVisualManager.getVisualManager().changeVisual(c_lass);
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
