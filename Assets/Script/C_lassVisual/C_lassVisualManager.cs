using UnityEngine;

public class C_lassVisualManager : MonoBehaviour
{
    private static C_lassVisualManager visualManager;
    private GameObject c_lassVisual;

    void Start()
    {
        if (visualManager == null)
        {
            visualManager = this;
        }

        c_lassVisual = GameObject.Find("C_lassVisual");
        
    }

    public static C_lassVisualManager getVisualManager()
    {
        return visualManager;
    }

    public void changeVisual(string c_lass)
    {
        C_lassVisual cVisual = c_lassVisual.GetComponent<C_lassVisual>();
        cVisual.changeVisual(c_lass);
    }
}