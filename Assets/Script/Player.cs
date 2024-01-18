using System.Collections;
using System.Collections.Generic;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Stat stat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log(stat.ToString());
    }
    public static void setStat(Stat st)
    {
        stat = st;
    }
}
