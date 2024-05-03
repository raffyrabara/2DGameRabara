using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCan : MonoBehaviour
{
    //public GameObject heroCopy;
    public HeroManager heroCopy;
    public GameObject fuelCanToDeactivate;
    [SerializeField] private AudioSource FuelSoundEffect;
    [SerializeField] private AudioSource FuelTalkSoundEffect;
    public int value;
    //private int counter;
    // Start is called before the first frame update
    void Start()
    {
        value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       // counter = counter + 1;
        //if (heroCopy.health < heroCopy.maxhealth)
        {   
            FuelSoundEffect.Play();
            FuelTalkSoundEffect.Play();
            fuelCanToDeactivate.SetActive(false);
            heroCopy.IncreaseHealth(10);
            FuelCanCounter.instance.IncreaseFuelCan(value);
            
        }

    }
}
