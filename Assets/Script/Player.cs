using System.Collections;
using System.Collections.Generic;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Charater charater;
    private Skill[] skillSet = new Skill[4];
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    }

    public void setCharater(Charater charater)
    {
        this.charater = charater;
    }

    public void setSkillSet(Skill[] skillSet)
    {
        this.skillSet = skillSet;
    }
    
    public void c_lassInfo()
    {
        Debug.Log(charater.ToString());
        for (int i = 0; i < skillSet.Length; i++)
        {
            Debug.Log(skillSet[i].ToString());
        }
    }
}
