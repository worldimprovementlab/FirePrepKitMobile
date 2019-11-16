using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void GoTo3dScanHome()
    {
        Debug.Log("Going to 3d scan of home");
    }

    public void GoToReviewPlan()
    {
        Debug.Log("Going to review of plan");
    }

    public void GoToSmokeDetectorPlacement()
    {
        Debug.Log("Going to smoke detector placement");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorPlacement");
    }


    public void GoToSmokeDetectorTestScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorTestScene");
    }

    

}
