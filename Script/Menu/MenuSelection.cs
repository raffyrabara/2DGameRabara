using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject optionPanel;
    // Start is called before the first frame update
void Start()
{
    exitPanel.SetActive(false);
    optionPanel.SetActive(false);
}


    public void PlayGame()
{
   SceneManager.LoadScene("Level_0");
}

public void OptionSelect()
{
   optionPanel.SetActive(true);

}

public void BackToMenu()
{
    optionPanel.SetActive(false);
}

public void QuitGame()
   {
     exitPanel.SetActive(true);
   }

public void YesSelect()
   {
    Application.Quit();
   }

public void NoSelect()
    {   
        exitPanel.SetActive(false);
    }   
}
