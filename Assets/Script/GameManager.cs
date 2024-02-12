using System.Collections;
using System.Collections.Generic;
using Script;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public GameObject player;
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        /*
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }*/
    }

    void Update()
    {
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Find Player");
        player = GameObject.FindWithTag("Player");
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    public static GameManager getGameManager()
    {
        return gameManager;
    }

    public GameObject getPlayer()
    {
        return player;
    }
    
    public void send(string type)
    {
    }

    public void setPlayer(Player player)
    {
        Debug.Log("Destroy player");
        Destroy(player.GetComponent<Player>());
    }
    
    public void setPlayerC_lass(Charater charater)
    {
        playerScript().setCharater(charater);
    }

    public void setSkills(Skill[] skills)
    {
        playerScript().setSkillSet(skills);
    }

    public Player playerScript()
    {
        return player.GetComponent<Player>();
    }
}

