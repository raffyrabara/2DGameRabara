using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;


public class HeroManager : MonoBehaviour
{
    
    //private float deltaX;
    private Animator anim;
    private Rigidbody2D rb;

    public float health;
    public float maxhealth = 100f;

    private bool isGrounded;
    private Vector3 localScale;

    private float moveSpeed;
    private float moveInput;

    float horizontalInput;
    //float moveSpeed;
    bool isFacingRight = false;
    float jumpPower = 15f;

    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource footstepSoundEffect;
    [SerializeField] private AudioSource startSoundEffect;
    [SerializeField] private AudioSource DeathSoundEffect;
    

    private bool isFootstepPlaying = false;
    private float footstepTimer = 0f;
    public float footstepDelay = 0.5f;

     private bool isDead = false;

    public GameOverManager gameOverManager;
    public MobileJoyStick joyStick;
   
    // Start is called before the first frame update
    void Start()
    {
       // deltaX  = 0.1f;
        //deltaX  = 0.08f;
        anim = GetComponent<Animator>();
        rb = transform.GetComponent<Rigidbody2D>();
        isGrounded = true;
        health = maxhealth;
        //anim.SetInteger("Transition", 1);
        startSoundEffect.Play();
        moveSpeed = 10f;
        joyStick = FindObjectOfType<MobileJoyStick>(); 

        localScale  = transform.localScale;

    }

    public void IncreaseHealth(int updateParam)
    {
        health = health + updateParam;
       if (health > maxhealth)
            health = maxhealth;
    }

     public void DecreaseHealth(int updateParam)
    {
        health = health - updateParam;
        
        if (health <= 0 && !isDead)
        {     
            HeroDie();
            anim.SetBool("isDied", true);
            
        }
     
    }

    public void HeroDie ()
    {
            isDead = true;
            DeathSoundEffect.Play();
            gameOverManager.gameOverActive();
            anim.SetBool("isDied", true);
    }
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        anim.SetBool("isJumping", !isGrounded);
        

    }
  /* void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            PlayHurtSound();
        }
    }

    void PlayHurtSound()
    {
        hurtSoundEffect.Play();
    }*/
    // Update is called once per frame
    void Update()
    {

        
     if(!PauseManager.isPaused && !SummaryGameManager.isSummary && !GameOverManager.isGO)
       {    
        //horizontalInput = Input.GetAxis ("Horizontal");
         horizontalInput = joyStick ? joyStick.JoystickInput.x : 0;
        FlipSprite();

        
            if (Mathf.Abs(horizontalInput) > 0.01f)
        {
            // Play footstep sound when moving horizontally
            if (!isFootstepPlaying)
            {
                PlayFootstepSound();
            }
        }
        else
        {
            // If not moving horizontally, set to stand animation
            StopFootstepSound();
        }
       }
    }

    public void JumpButton()
        {
            if(!PauseManager.isPaused && !SummaryGameManager.isSummary && !GameOverManager.isGO && isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                    jumpSoundEffect.Play();
                    isGrounded = false;
                    anim.SetBool("isJumping", !isGrounded);
            }
        }
    
        void PlayFootstepSound()
    {
        footstepSoundEffect.Play();
        isFootstepPlaying = true;
        footstepTimer = footstepDelay;
    }

    void StopFootstepSound()
    {
        isFootstepPlaying = false;
        footstepTimer = 0f;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        anim.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("yVelocity", rb.velocity.y);

        if (footstepTimer > 0f)
        {
            footstepTimer -= Time.fixedDeltaTime;
            if (footstepTimer <= 0f)
            {
                StopFootstepSound();
            }
        }
    }   

    void FlipSprite()
    {
        if(isFacingRight && horizontalInput > 0f || !isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }

    }


}

        

