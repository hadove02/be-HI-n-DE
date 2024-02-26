using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public string name;
    
    void Start()
    {
        this.name = transform.parent.name;
    }
    public void ButtonClick()
    {
        GameManager.gameManager().changePlayer(name);
        ChangeMenu.setMainMenu(true);
        ChangeMenu.setCharacterSelect(false);
        
    }
    
    
    void Update()
    {
        
    }
}
