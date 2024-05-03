using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAndCollectiblesManager : MonoBehaviour
{
    public GameObject Laser1;
    public GameObject Laser2;
    public KeyManager Key;
    public Invulnerability Potion;
    public GameObject parentChecker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!parentChecker.activeSelf)
        {
            Laser1.SetActive(true);
            Laser2.SetActive(true);
            Potion.transform.position = new Vector2 (Potion.transform.position.x, -0.1f);
            Key.transform.position = new Vector2 (Key.transform.position.x, -0.02f);
        }
    }
}
