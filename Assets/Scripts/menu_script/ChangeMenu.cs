using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class ChangeMenu : MonoBehaviour
{
    private string button_name;
    private static GameObject top_menu;

    void Start()
    {
        button_name = transform.name;
        top_menu = GameObject.Find("top_menu");
    }

    public void ButtonClick()
    {
        switch (button_name)
        {
            case "Character_Choice_Button":
            {
                characterSelect();
                break;
            }
            case "Start_Button":
            {
                gameStart();
                break;
            }
            case "Back_Button":
            {
                backButton();
                break;
            }
            case "Game_Mode":
            {
                GameManager.gameManager().setGameMode(gameMode());
                break;
            }
        }
    }

    private void characterSelect()
    {
        setCharacterSelect(true);
        setMainMenu(false);
    }

    private void backButton()
    {
        setMainMenu(true);
        transform.parent.gameObject.SetActive(false);
    }

    private void gameStart()
    {
        SceneManager.LoadScene("GameScene");    
    }

    private int gameMode()
    {
        const int ERROR = -1, RANK = 0, NORMAL = 1;
        TMP_Text tmp = transform.GetChild(0).GetComponent<TMP_Text>();
        if (tmp.text.Equals("일반"))
        {
            tmp.text = "랭크";
            return RANK;
        }else if (tmp.text.Equals("랭크"))
        {
            tmp.text = "일반";
            return NORMAL;
        }

        return ERROR;
    }
    public static void setMainMenu(bool active)
    {
        top_menu.transform.Find("mainMenu").gameObject.SetActive(active);
    }

    public static void setCharacterSelect(bool active)
    {
        top_menu.transform.Find("selectCharacter").gameObject.SetActive(active);
    }
}