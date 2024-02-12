using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send : MonoBehaviour
{
    void OnMouseDown()
    {
        Player player = GameManager.getGameManager().getPlayer().GetComponent<Player>();
        player.c_lassInfo();
        SceneManagement.sceneChange("FightScene");
        GameManager.getGameManager().setPlayer(player);
        Debug.Log("yaho");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
