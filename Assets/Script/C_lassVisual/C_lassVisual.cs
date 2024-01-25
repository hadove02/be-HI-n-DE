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
            transform.Find(currentChanged).gameObject.SetActive(false);
        }

        transform.Find(c_lass).gameObject.SetActive(true);
        currentChanged = c_lass;
    }
}
