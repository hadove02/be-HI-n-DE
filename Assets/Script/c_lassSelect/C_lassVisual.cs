using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_lassVisual : MonoBehaviour
{
    private string currentSelected;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void changeVisual(string name)
    {
        if (currentSelected != null)
        {
            transform.Find(currentSelected).gameObject.SetActive(false);
        }

        transform.Find(name).gameObject.SetActive(true);
        currentSelected = name;
    }
}