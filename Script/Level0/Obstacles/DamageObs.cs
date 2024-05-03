using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObs : MonoBehaviour
{
    //public GameObject heroCopy;
    public int damagepoint;
    public HeroManager heroCopy;
    [SerializeField] public AudioSource EnemyDamageAudio;
    private bool hasCollided = false;
  //  private int counter;
    // Start is called before the first frame update
    void Start()
    {
        //counter = 0;
        damagepoint = 8;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision hasn't occurred yet
        if (!hasCollided && collision.CompareTag("Player")) 
        {
            EnemyDamageAudio.Play();
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
