using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

// NOTE: Code taken from: https://www.youtube.com/watch?v=POq1i8FyRyQ
public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer_txt;
    public bool timerActive = false;

    public GameObject player;
    public GUIManager GUIManager;
    public playerstuff playerstuff;
    public float remainingTime;
    void Start()
    {
        remainingTime = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            timerActive = true;
        }
        if (remainingTime > 0 && timerActive)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0 && timerActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<MouseMovement>().enabled = true;
            player.GetComponent<PlayerMovement>().enabled = true;
            player.GetComponent<cameraTest>().ShowHubCamera();
            GUIManager.IncreaseDay();
            remainingTime = (int)(playerstuff.day_level * 60);
            timerActive = false;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer_txt.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
