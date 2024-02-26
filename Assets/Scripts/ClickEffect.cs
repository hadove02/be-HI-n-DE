using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEffect : MonoBehaviour
{
    private Animator anim;
    enum Skill
    {
        skill_one_cost = 2,
        skill_two_cost = 3, 
    }
    PlayerMove pm;
    
    public GameObject firePoint;
    public GameObject effect1;
    public GameObject effect2;
    private GameObject tempEffect;

    public int tempSkill = 0;
    public int skillMotion = 0;
    private int cost = 5;

    public GameObject[] costs = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            tempSkill = 1;
            skillMotion = 1;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            tempSkill = 2;
            skillMotion = 2;
        }

        if (Input.GetMouseButtonDown(0) && tempSkill == 1)
        {
            if (cost >= 2)
            {
                Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                clickPosition.z = 0;

                tempEffect = Instantiate(effect1, clickPosition, Quaternion.identity);
                StartCoroutine(DestroyDelay(0.7f));
                tempSkill = 0;

                //int[] countList = new int[cost];
                int count = 0;
                for (int i = costs.Length - 1; i >= 0 ; i--)
                {
                    if (count == 2)
                    {
                        break;
                    }
                    else if (costs[i].activeSelf == true)
                    {
                        costs[i].SetActive(false);
                        count++;
                    }
                }
                cost -= 2;
            }
        }
        else if (Input.GetMouseButtonDown(0) && tempSkill == 2)
        {
            if (cost >= 3)
            {
                Vector3 clickPosition = firePoint.transform.position;
                //1.52

                if (pm.dir == 1)
                {
                    effect2.transform.localScale = new Vector3(10, 10, 1);
                    clickPosition.x += 2f;
                }
                else
                {
                    effect2.transform.localScale = new Vector3(-10, 10, 1);
                    clickPosition.x += -2f;
                }
                tempEffect = Instantiate(effect2, clickPosition, Quaternion.identity);
                StartCoroutine(DestroyDelay(1.2f));
                tempSkill = 0;

                int count = 0;
                for (int i = costs.Length - 1; i >= 0 ; i--)
                {
                    if (count == 3)
                    {
                        break;
                    }
                    else if (costs[i].activeSelf == true)
                    {
                        costs[i].SetActive(false);
                        count++;
                    }
                }
                cost -= 3;
            }
        }
    }
    IEnumerator DestroyDelay(float delay)
    { 
        yield return new WaitForSeconds(delay);
        Destroy(tempEffect);
    }
}
