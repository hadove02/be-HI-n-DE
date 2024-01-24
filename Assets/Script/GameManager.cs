using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    private GameObject player;
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
    }

    void Update()
    {
        
    }

    public static GameManager getGameManager()
    {
        return gameManager;
    }

    public GameObject getPlayer()
    {
        return player;
    }
}

