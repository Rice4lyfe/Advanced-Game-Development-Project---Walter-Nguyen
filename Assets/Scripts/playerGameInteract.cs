using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGameInteract : MonoBehaviour
{
    public GameObject player;
    public GameObject playerUI;
    public playerstuff playerstuff;
    public cameraTest cameraTest;

    public bool gameActive = false;
    public bool objExists = false;

    public Timer timer;
    public GameObject[] prefab;
    private GameObject spawnedLetter;
    public int currentIndex = 0;
    public Transform spawn;
    public int correctLetter = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            other.GetComponent<MouseMovement>().enabled = false;
            other.GetComponent<PlayerMovement>().enabled = false;
            cameraTest.ShowGameCamera();
            gameActive = true;
            timer.timerActive = true;
        }    
    }

    private void Update() 
    {
        if(timer.remainingTime <= 0)
        {
            gameActive = false;
            Destroy(spawnedLetter);
            objExists = false;
        }
        if(gameActive && objExists == false)
        {
            SpawnLetter();
            Debug.Log("I have spawned the thing!");
            objExists = true;
        }
        if(gameActive && objExists == true)
        {
            if (Input.GetKeyDown(KeyCode.A) && correctLetter == 0)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE THING!");
                playerUI.GetComponent<GUIManager>().ChangeScore(1000);
                objExists = false;
            }
            if (Input.GetKeyDown(KeyCode.A) && correctLetter != 0)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE BUT I GOT PENALIZED!");
                playerUI.GetComponent<GUIManager>().ChangePenalty(1);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.S) && correctLetter == 1)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE THING!");
                playerUI.GetComponent<GUIManager>().ChangeScore(1000);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.S) && correctLetter != 1)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE BUT I GOT PENALIZED!");
                playerUI.GetComponent<GUIManager>().ChangePenalty(1);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.D) && correctLetter == 2)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE THING!");
                playerUI.GetComponent<GUIManager>().ChangeScore(1000);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.D) && correctLetter != 2)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE BUT I GOT PENALIZED!");
                playerUI.GetComponent<GUIManager>().ChangePenalty(1);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.F) && correctLetter == 3)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE THING!");
                playerUI.GetComponent<GUIManager>().ChangeScore(1000);
                objExists = false;
            }
            else if (Input.GetKeyDown(KeyCode.F) && correctLetter != 3)
            {
                Destroy(spawnedLetter);
                Debug.Log("I DESTORYED THE BUT I GOT PENALIZED!");
                playerUI.GetComponent<GUIManager>().ChangePenalty(1);
                objExists = false;
            }
            // else
            // {
            //     Destroy(spawnedLetter);
            //     Debug.Log("I DESTORYED THE THING BUT IT WAS WRONG!");
            //     playerUI.GetComponent<GUIManager>().ChangePenalty(1);
            //     objExists = false;
            // }
        }
    }

    void SpawnLetter()
    {
        int randomIndex = Random.Range(0,prefab.Length);
        correctLetter = randomIndex;
        spawnedLetter = Instantiate(prefab[randomIndex],spawn.position,Quaternion.identity);
    }
}
