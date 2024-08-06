using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerInteraction : MonoBehaviour
{
    public GameObject confirmationScreen;
    public Button confirmButton;
    public GameObject player;

    private void Start() {
        confirmationScreen.SetActive(false);
        confirmButton.onClick.AddListener(OnConfirmedClicked);
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            confirmationScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            other.GetComponent<MouseMovement>().enabled = false;
            other.GetComponent<PlayerMovement>().enabled = false;
        }    
    }

    void OnConfirmedClicked()
    {
        confirmationScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<MouseMovement>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
