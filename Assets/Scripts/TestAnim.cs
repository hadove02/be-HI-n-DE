using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnim : MonoBehaviour
{
    private Animator anim;
    private ClickEffect ce;
    // Start is called before the first frame update
    void Start()
    {
        ce = GetComponent<ClickEffect>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("AttackMagic");
        }
        */
        if (ce.skillMotion == 1 && Input.GetMouseButtonDown(0))
        {
            ce.skillMotion = 0;
            anim.SetTrigger("AttackMagic");
        }
        if (ce.skillMotion == 2 && Input.GetMouseButtonDown(0))
        {
            ce.skillMotion = 0;
            anim.SetTrigger("MagicR");
        }
    }
}
