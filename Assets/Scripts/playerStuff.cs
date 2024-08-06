using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerstuff : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tool_level_txt;
    [SerializeField] private TextMeshProUGUI day_level_txt;
    [SerializeField] private TextMeshProUGUI food_level_txt;

    public GameObject playerUI;

    public Timer timer;

    public int tool_level;
    public int day_level;
    public int food_level;
    private void Start() {
        tool_level = 1;
        day_level = 1;
        food_level = 1;
        SetUpgradeDisplay();
    }
    
    #region Upgrades
    public void IncreaseToolLevel()
    {
        tool_level++;
        SetUpgradeDisplay();
    }
    public void IncreaseDayLevel()
    {
        day_level++;
        SetUpgradeDisplay();
        switch(day_level)
        {
            case 2:
                playerUI.GetComponent<Timer>().remainingTime = 120;
                break;
            case 3:
                playerUI.GetComponent<Timer>().remainingTime = 180;
                break;
            case 4:
                playerUI.GetComponent<Timer>().remainingTime = 240;
                break;
            case 5:
                playerUI.GetComponent<Timer>().remainingTime = 300;
                break;
            default:
                playerUI.GetComponent<Timer>().remainingTime = 60;
                break;
        }
    }
    public void IncreaseFoodLevel()
    {
        food_level++;
        SetUpgradeDisplay();
    }

    public void ResetUpgrades()
    {
        tool_level = 1;
        day_level = 1;
        food_level = 1;
        SetUpgradeDisplay();
    }

    private void SetUpgradeDisplay()
    {
        tool_level_txt.text = tool_level.ToString();
        day_level_txt.text = day_level.ToString();
        food_level_txt.text = food_level.ToString();
    }
    #endregion
}
