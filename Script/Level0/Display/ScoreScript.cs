using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public GameObject startPos;
    public TextMeshProUGUI scoreText;
    public GameObject scoreTextObj;
    public TextMeshProUGUI scoreSummaryText;
    public GameObject scoreSummaryTextObj;
    private float distance;
    private float lastPosition;

    private float highscore = 0;
    private float top1 = 0;
   // private float top2 = 0;
   // private float top3 = 0;

    public TextMeshProUGUI top1_Score;
    //public TextMeshProUGUI top2_Score;
    //public TextMeshProUGUI top2_Score;

    public TextMeshProUGUI HighscoreText;
    // Start is called before the first frame update
    void Start()
    {
      
        distance = 0f;
        lastPosition = startPos.transform.position.x;
        scoreText = scoreTextObj.GetComponent<TextMeshProUGUI>();
        scoreSummaryText = scoreSummaryTextObj.GetComponent<TextMeshProUGUI>();

        highscore = PlayerPrefs.GetFloat("Highscore", 0f);
        HighscoreText.text = highscore.ToString("F1") + ("m");

        top1 = PlayerPrefs.GetFloat("Highscore", 0f);
        top1_Score.text = highscore.ToString("F1") + ("m");

      /*  top2 = PlayerPrefs.GetFloat("Highscore", 0f);
        top2_Score.text = highscore.ToString("F1") + ("m");

        top3 = PlayerPrefs.GetFloat("Highscore", 0f);
        HighscoreText.text = highscore.ToString("F1") + ("m");*/
    }

    // Update is called once per frame
    void Update()
    {
        float currentPosition = this.transform.position.x;
        if (currentPosition > lastPosition)
        {
        //distance =  (startPos.transform.position.x + this.transform.position.x);
        distance += currentPosition - lastPosition;
        lastPosition = currentPosition;
        }

        scoreText.text = distance.ToString("F1") + ("m");
        scoreSummaryText.text = distance.ToString("F1") + ("m");

/*/if (distance > top1)
        {
            // Update the high score
            top1 = distance;
            top1_Score.text = top1.ToString("F1") + "m";

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetFloat("Top1", top1);
            PlayerPrefs.Save(); // Make sure to save changes
        }*/

    
if (distance > highscore)
        {
            // Update the high score
            highscore = distance;
            top1 = highscore;
            HighscoreText.text = highscore.ToString("F1") + "m";
            top1_Score.text = top1.ToString("F1") + "m";

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetFloat("Highscore", highscore);
            PlayerPrefs.Save(); // Make sure to save changes
        }

    }
}
