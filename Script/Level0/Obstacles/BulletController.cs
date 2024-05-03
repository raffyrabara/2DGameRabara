using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;
    private Animator anim;
    [SerializeField] private AudioSource FireSoundEffect;


    private float timer;
    private GameObject player;

    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        anim.SetBool("isFire", false);
    }

     void Update()
    {
        //anim.SetBool("isFire", false);
        float distance = Vector2.Distance(transform.position, player.transform.position);
        
        if(distance < 10)
        {
            timer += Time.deltaTime;

               if(timer >2) 
                    {
                        timer = 0;
                        shoot();
                    }
        }
        else
        anim.SetBool("isFire", false);
    }
    void shoot()
    {
        //GameController[] gameControllers = FindObjectsOfType<GameController>();
        anim.SetBool("isFire", true);
        FireSoundEffect.Play();
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
 
}