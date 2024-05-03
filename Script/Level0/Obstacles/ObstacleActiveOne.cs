using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleActiveOne : MonoBehaviour
{
  public GameObject obstacle1;
  public GameObject obstacle2;
 // public KeyManager keyActivate;
 // public Invulnerability potionActivate;
   // public GameObject keycanActive;
   // private float origKeyposition = -3.2f;
    //initialDeact;
   // private float deltaX;
    // Start is called before the first frame update
    void Start()
    {
       // deltaX = 102.48f;
        //initialDeact.SetActive(false);
        //sensorToDeact.SetActive(false);
        //sensor2Deactivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(obstacle1.activeSelf && !obstacle2.activeSelf)
        {
            obstacle1.SetActive(false);
            obstacle2.SetActive(true);
           // keyActivate.transform.position = new Vector2 (keyActivate.transform.position.x, keyActivate.transform.position.y);
           // potionActivate.transform.position = new Vector2 (potionActivate.transform.position.x, potionActivate.transform.position.y);
        }
        else if(!obstacle1.activeSelf && obstacle2.activeSelf)
        {   obstacle2.SetActive(false);
            obstacle1.SetActive(true);
        }
      //  keycanActive.SetActive(true);
       // keycanActive.transform.position = new Vector2 (keycanActive.transform.position.x, origKeyposition);
        
    }   
}
