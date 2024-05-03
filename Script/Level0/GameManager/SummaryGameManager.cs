using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SummaryGameManager : MonoBehaviour
{
    public static bool isSummary;
    public GameObject gameSummary;
    public GameObject gameOver;
    public GameObject LeaderBoardPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameSummary.SetActive(false);
        LeaderBoardPanel.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
       
        if(isSummary)
        {
            Time.timeScale = 0f;
        }
    
    }
  
public void PlayAgain()
{
    Time.timeScale = 1f;
    SceneManager.LoadScene("Level_0");
    isSummary = false;
    GameOverManager.isGO = false;
    gameSummary.SetActive(false);
    gameOver.SetActive(false);

}

public void HomeButton()
{
    Time.timeScale = 1f;
    SceneManager.LoadScene("MainMenu");
    isSummary = false;
    GameOverManager.isGO = false;
    gameSummary.SetActive(false);
    gameOver.SetActive(false);
   
}

public void LeaderBoard()
{
    LeaderBoardPanel.SetActive(true);
}

public void BackToLeader()
{
    LeaderBoardPanel.SetActive(false);
}

}
