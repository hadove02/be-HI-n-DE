using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_lassSelectManager : MonoBehaviour
{
    private static C_lassSelectManager c_lassSelectManager;
    private static GameObject c_lassVisual;
    void Start()
    {
        if (c_lassSelectManager == null)
        {
            c_lassSelectManager = this;
        }

        c_lassVisual = GameObject.Find("C_lassVisual");
    }
    void Update()
    {
        
    }

    public static void changeVisual(string c_lass)
    {
        C_lassVisual cVisual = c_lassVisual.GetComponent<C_lassVisual>();
        cVisual.changeVisual(c_lass);
    }
}
