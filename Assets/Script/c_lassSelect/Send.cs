using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Send : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Player player = GameManager.getGameManager().getPlayer().GetComponent<Player>();
        player.info();
    }
}
