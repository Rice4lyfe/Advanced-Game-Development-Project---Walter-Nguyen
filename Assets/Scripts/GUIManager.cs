using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GUIManager : MonoBehaviour
{
    public static GUIManager instance;
    [SerializeField] private TextMeshProUGUI score_txt;
    [SerializeField] private TextMeshProUGUI day_txt;
    [SerializeField] private TextMeshProUGUI penalty_txt;

    
    private int score;
    private int day;
    private int penalty;
    
    private void Awake() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad (gameObject);
        }
        else
        {
            Destroy (gameObject);
        }
    }
    
    void Start()
    {
        score = 0;
        penalty = 0;
        day = 0;
        
        SetScoreDisplay();
        SetDayDisplay();
        SetPenaltyDisplay();
        
    }

    #region Score
    private void SetScoreDisplay()
    {
        score_txt.text = score.ToString();
    }

    public void ChangeScore(int value)
    {
        score += value;
        SetScoreDisplay();
    }

    #endregion

    #region Penalty
    private void SetPenaltyDisplay()
    {
        penalty_txt.text = penalty.ToString();
    }

    public void ChangePenalty(int value)
    {
        penalty += value;
        SetPenaltyDisplay();
    }

    public void ResetPenalty()
    {
        penalty = 0;
        SetPenaltyDisplay();
    }

    #endregion

    #region Day
    private void SetDayDisplay()
    {
        day_txt.text = day.ToString();
    }

    public void IncreaseDay()
    {
        day++;
        SetDayDisplay();
    }

    #endregion

    
    private void Update() {
        // if (Input.GetKeyDown(KeyCode.F))
        // {
        //     ChangeScore(1000);
        // }
        // //Press F to increase score, test to see if score works
        // if (Input.GetKeyDown(KeyCode.R))
        // {
        //     ChangePenalty(1);
        // }
        if(penalty >= 10)
        {
            Application.Quit();
            Debug.Log("Congrats! You died.");
        }
    }
}
