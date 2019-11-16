using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void GoTo3dHomeScanner()
    {
        Debug.Log("Going to 3d scan of home");
    }

    public void GoToChecklists()
    {
        Debug.Log("Going to review of plan");
    }

    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }

    public void GoToSmokeDetectorPlacement()
    {
        //Debug.Log("Going to smoke detector placement");
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorList");
    }


    public void GoToSmokeDetectorTestScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorTestScene");
    }

    

}
