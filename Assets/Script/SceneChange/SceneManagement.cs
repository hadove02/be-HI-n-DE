using System.Threading.Tasks;
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

    public static async Task<AsyncOperation> sceneChange(string sceneName)
    {
        //SceneManager.LoadSceneAsync(sceneName);
        return SceneManager.LoadSceneAsync(sceneName);
    }
        
}
