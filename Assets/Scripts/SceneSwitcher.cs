using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void GoTo3dHomeScan()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("3dHomeScan");
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("PreIncidentPlan");
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
