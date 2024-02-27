using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click_Event : MonoBehaviour
{

    private Vector2 normalSize = new Vector2(0.33f, 0.33f);
    private Vector2 clickedSize = new Vector2(0.264f, 0.264f);


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