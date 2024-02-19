using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Send : MonoBehaviour
{
    private Player send_player;
    async void OnMouseDown()
    {
        Player pp = await changeScene();
        pp.c_lassInfo();
        setPlayer(pp);
    }

    private async Task<Player> changeScene()
    {
        Player player = GameManager.getGameManager().getPlayer().GetComponent<Player>();
        AsyncOperation scene = await SceneManagement.sceneChange("FightScene");
        while (!scene.isDone)
        {
            await Task.Delay(1000);
            Debug.Log("wait" + scene.progress);
        }
        
        Debug.Log("Done");
        return player;
    }

    private void setPlayer(Player player)
    {
        GameManager.getGameManager().getPlayerComponent().setPlayer(player.getCharater(),player.getSkillSet());
        GameManager.getGameManager().getPlayer().GetComponent<visualbe>().updated();
        
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}