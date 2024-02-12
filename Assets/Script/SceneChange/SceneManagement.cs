using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //private static SceneManagement sceneManagement;

    void Start()
    {
        /*
        if (sceneManagement == null)
        {
            sceneManagement = this;
        }*/
    }
    void Update()
    {
        
    }
    /*
    public static SceneManagement getSceneManagement()
    {
        return sceneManagement;
    }*/

    public static void sceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
        
}
