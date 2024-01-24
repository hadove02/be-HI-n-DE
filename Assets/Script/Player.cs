        using System.Collections;
using System.Collections.Generic;
using Script;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Character character;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void info()
    {
        Debug.Log(character.ToString());
    }
    
    public void setCharacter(Character ch)
    {
        character = ch;
    }
}
