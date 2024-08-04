using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Game Loaded Successfully!");
    }

    public void storyGame()
    {
        SceneManager.LoadScene("Story");
        Debug.Log("Story Loaded Successfully!");
    }

    public void tutorialGame()
    {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Tutorial Loaded Successfully!");
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Mainmenu");
        Debug.Log("Main Menu Returned Successfully!");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit Successfully!");
    }
}
