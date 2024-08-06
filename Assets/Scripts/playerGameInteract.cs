using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGameInteract : MonoBehaviour
{
    public GameObject player;
    public GameObject playerUI;
    public playerstuff playerstuff;
    public cameraTest cameraTest;
    public Timer timer;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            other.GetComponent<MouseMovement>().enabled = false;
            other.GetComponent<PlayerMovement>().enabled = false;
            cameraTest.ShowGameCamera();
            timer.timerActive = true;
        }    
    }
}
