using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send : MonoBehaviour
{
    void OnMouseDown()
    {
        Player player = GameManager.getGameManager().getPlayer().GetComponent<Player>();
        player.c_lassInfo();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
