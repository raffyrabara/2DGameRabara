using System.Collections;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject lazerDeact;
    public GameObject lazerDeact2;
    public GameObject keyDeact;
    [SerializeField] private AudioSource LaserSoundEffect;
    [SerializeField] private AudioSource KeySoundEffect;
   // private float deltaY;
    private bool obstaclesDeactivated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyDeact.transform.position = new Vector2 (keyDeact.transform.position.x, keyDeact.transform.position.y + 15f);
        LaserSoundEffect.Play();
        KeySoundEffect.Play();
        if (!obstaclesDeactivated)
        {
            obstaclesDeactivated = true;
            StartCoroutine(DeactivateObstaclesWithDelay());
        }
            obstaclesDeactivated = false;
    }

    private IEnumerator DeactivateObstaclesWithDelay()
    {
        lazerDeact.SetActive(false);
        yield return new WaitForSeconds(0.3f); // Wait for 0.1 seconds
        lazerDeact2.SetActive(false);
        

    }
}
