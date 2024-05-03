using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
    public GameObject prefabToMove;
    public GameObject sensorToActivate, sensorToDeact;
    public GameObject fuelCanToActivate;
    //initialDeact;
    private float deltaX;
    // Start is called before the first frame update
    void Start()
    {
        deltaX = 102.48f;
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
        if (collision.CompareTag("Player"))
        {
        sensorToActivate.SetActive(true);
        prefabToMove.transform.position = new Vector2 (prefabToMove.transform.position.x + deltaX, prefabToMove.transform.position.y);
        sensorToDeact.SetActive(false);
        fuelCanToActivate.SetActive(true);
        }
    }   
}
