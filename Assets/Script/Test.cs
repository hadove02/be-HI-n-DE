using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        GameManager.getGameManager().getPlayer().GetComponent<Player>().c_lassInfo();   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
