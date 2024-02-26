using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    private Animator anim;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, y, 0);

        transform.Translate(dir * speed * Time.deltaTime);

        if (x != 0 || y != 0)
        {
            anim.SetFloat("RunState", 0.5f);
        }
        else 
        {
            anim.SetFloat("RunState", 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("AttackMagic");
        }
    }
}
