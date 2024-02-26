using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MP : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Slider mpbar;

    private float maxHp = 100;
    private float curHp = 100;

    private float temp;

    void Start()
    {
        mpbar.value = (float)curHp / (float)maxHp;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (curHp > 0)
            {
                curHp -= 10;
            }
            else
            {
                curHp = 0;
            }

        }
        temp = (float)curHp / (float)maxHp;
        HandleHp();
    }

    private void HandleHp()
    {
        mpbar.value = Mathf.Lerp(mpbar.value, temp, Time.deltaTime * 10);
    }
}

