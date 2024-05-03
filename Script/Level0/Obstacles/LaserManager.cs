using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserManager : MonoBehaviour
{
    public HeroManager heroCopy;
    public int damagepoint;
    private bool hasCollided = false; // Track whether a collision has occurred
    [SerializeField] public AudioSource LazerSoundEffect;
    

    void Start()
    {
        damagepoint = 4;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision hasn't occurred yet
        if (!hasCollided && collision.CompareTag("Player")) 
        {
            LazerSoundEffect.Play();
            heroCopy.DecreaseHealth(damagepoint);
            hasCollided = true; // Set the flag to true to prevent repeated collisions
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            hasCollided = false;
        }
    }
}
