using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_lassVisual : MonoBehaviour
{
    private string currentChanged;

    public void changeVisual(string c_lass)
    {
        if (currentChanged != null)
        {
            Destroy(GameObject.Find(currentChanged+("(Clone)")));
        }
        Instantiate(Resources.Load<GameObject>("SPUM/SPUM_Units/" + c_lass),
            GameObject.Find("C_lassVisual").transform.position,
            Quaternion.identity);
        currentChanged = c_lass;
    }
}
