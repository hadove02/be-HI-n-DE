using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualbe : MonoBehaviour
{
    private bool updateDone;

    void Start()
    {
        updateDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (updateDone)
        {
            string c_lassName = GameManager.getGameManager().getPlayerComponent().getCharater().getName();
            Instantiate(Resources.Load<GameObject>("SPUM/SPUM_Units/" + c_lassName),
                GameObject.FindWithTag("Player").transform.position,
                Quaternion.identity);
            updateDone = false;
        }

        //Destroy(this);
    }

    public void updated()
    {
        updateDone = true;
    }
}