using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject gameSummary;
    [SerializeField] private AudioSource BGMusicToOFf;
    [SerializeField] private AudioSource GameOverSound;
    public static bool isGO;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
       // isGO = false;
    }

    


    // Update is called once per frame
    public void gameOverActive()
    {   
        gameOver.SetActive(true);
        BGMusicToOFf.Stop();
        isGO = true;
        StartCoroutine (gameSummaryActive());

    }

    private IEnumerator gameSummaryActive ()
    {
        yield return new WaitForSeconds (2f);
        gameSummary.SetActive(true);
        GameOverSound.Play();
        SummaryGameManager.isSummary = true;
    
       // gameOver.SetActive(false);
    }
    
}
