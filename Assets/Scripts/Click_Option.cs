using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click_Option : MonoBehaviour
{

    private Vector2 normalSize = new Vector2(0.05957974f, 0.01072727f);
    private Vector2 clickedSize = new Vector2(0.047663792f, 0.008581816f);


    private void Start()
    {
    }

    private void OnMouseDown()
    {
        transform.localScale = clickedSize;
    }

    private void OnMouseUp()
    {
        transform.localScale = normalSize;
        //GetComponent<Transform>().sizeDelta = normalSize;
    }
}