using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager game_manager;
    private int game_mode;

    public GameObject player;
    public Vector2 player_vector;

    void Awake()
    {
        player = GameObject.Find("Player");
        player_vector = player.transform.Find("Player_prefab").position;
        
        if (game_manager == null)
        {
            game_manager = this;
        }
    }

    public void changePlayer(string name)
    {
        GameObject clone = Resources.Load<GameObject>("SPUM/SPUM_Units/" + name);
        clone.transform.localScale = new Vector3(5, 5, 5);

        GameObject temp = Instantiate(clone, player_vector, Quaternion.identity);
        
        Destroy(player.transform.Find("Player_prefab").gameObject);
        
        temp.transform.SetParent(player.transform);
        temp.name = "Player_prefab";
    }

    public static GameManager gameManager()
    {
        return game_manager;
    }

    public int getGameMode()
    {
        return game_mode;
    }

    public void setGameMode(int game_mode)
    {
        this.game_mode = game_mode;
    }
    
}