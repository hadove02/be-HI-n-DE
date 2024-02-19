using System.Collections;
using System.Collections.Generic;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Charater charater;
    private Skill[] skillSet = new Skill[4];
    public int test;

    public void setPlayer(Charater charater, Skill[] skillSet)
    {
        this.charater = charater;
        this.skillSet = skillSet;
    }

    public Charater getCharater()
    {
        return charater;
    }

    public Skill[] getSkillSet()
    {
        return skillSet;
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
