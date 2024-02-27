using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click_userInf : MonoBehaviour
{

    private Vector2 normalSize = new Vector2(0.13f, 0.02363636f);
    private Vector2 clickedSize = new Vector2(0.104f, 0.018909088f);


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
