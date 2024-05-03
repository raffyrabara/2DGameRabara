using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
  //  [SerializeField] private AudioSource HitSoundEffect;

void Start()
{
    rb = GetComponent<Rigidbody2D>();
    player = GameObject.FindGameObjectWithTag("Player");

    Vector3 direction = player.transform.position - transform.position;
    rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

    float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
    transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    
    
    }
   


void Update()
{
    timer += Time.deltaTime;

    if(timer > 5)
    {
        Destroy(gameObject);
    }


}

void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            // Destroy the bullet when it collides with the floor.
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the bullet when it collides with the hero.
            Destroy(gameObject);

            // Access the HeroManager script on the hero GameObject to apply damage.
            HeroManager heroManager = other.gameObject.GetComponent<HeroManager>();
            if (heroManager != null)
            {
                // Apply damage to the hero (modify this as needed).
                //HitSoundEffect.Play();
                heroManager.DecreaseHealth(5); // For example, decrease health by 10.
            }
        }
    }

} 