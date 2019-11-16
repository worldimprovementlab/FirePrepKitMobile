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
        UnityEngine.SceneManagement.SceneManager.LoadScene("Checklists");
    }

    public void GoToHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
    }

    public void GoToPreIncidentPlan()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HelloAR");
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
