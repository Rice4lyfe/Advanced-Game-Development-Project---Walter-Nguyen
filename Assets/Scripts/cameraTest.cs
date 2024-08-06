using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTest : MonoBehaviour
{
    public Camera hubCamera;
    public Camera gameCamera;
    
    public void ShowGameCamera()
    {
        hubCamera.enabled = false;
        gameCamera.enabled = true;
    }
    public void ShowHubCamera()
    {
        hubCamera.enabled = true;
        gameCamera.enabled = false;
    }

    private void Update() {
        // if (Input.GetKeyDown(KeyCode.R))
        // {
        //     ShowGameCamera();
        // }
        // if (Input.GetKeyDown(KeyCode.F))
        // {
        //     ShowHubCamera();
        // }
    }
}
