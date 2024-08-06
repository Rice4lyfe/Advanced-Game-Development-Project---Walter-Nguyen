using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerUpgradeInteract : MonoBehaviour
{
    public GameObject upgradeScreen;
    public Button upgradeToolButton;
    public Button upgradeTimeButton;
    public Button upgradeFoodButton;
    public Button resetButton;
    public Button cancelButton;
    public GameObject player;
    public GameObject playerUI;
    public playerstuff playerstuff;

    private void Start() {
        upgradeScreen.SetActive(false);
        upgradeToolButton.onClick.AddListener(OnToolUpgradeClicked);
        upgradeTimeButton.onClick.AddListener(OnTimeUpgradeClicked);
        upgradeFoodButton.onClick.AddListener(OnFoodUpgradeClicked);
        resetButton.onClick.AddListener(OnResetClicked);
        cancelButton.onClick.AddListener(OnCancelClicked);
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            upgradeScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            other.GetComponent<MouseMovement>().enabled = false;
            other.GetComponent<PlayerMovement>().enabled = false;
        }    
    }
    void OnToolUpgradeClicked()
    {
        if(playerUI.GetComponent<playerstuff>().tool_level >= 5)
        {
            playerUI.GetComponent<playerstuff>().tool_level = 5;
        }
        else
        {
            playerstuff.IncreaseToolLevel();
        }
    }
    void OnTimeUpgradeClicked()
    {
        if(playerUI.GetComponent<playerstuff>().day_level >= 5)
        {
            playerUI.GetComponent<playerstuff>().day_level = 5;
        }
        else
        {
            playerstuff.IncreaseDayLevel();
        }
    }
    void OnFoodUpgradeClicked()
    {
        if(playerUI.GetComponent<playerstuff>().food_level >= 5)
        {
            playerUI.GetComponent<playerstuff>().food_level = 5;
        }
        else
        {
            playerstuff.IncreaseFoodLevel();
        }
    }
    void OnResetClicked()
    {
        playerstuff.ResetUpgrades();
    }

    void OnCancelClicked()
    {
        upgradeScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<MouseMovement>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
