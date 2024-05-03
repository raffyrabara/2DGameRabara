using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private AudioSource fireSoundEffect;

    private void Start()
    {
        // Get the AudioSource component from the GameController
        fireSoundEffect = GetComponent<AudioSource>();
    }

    public void PlayFireSoundEffect()
    {
        // Play the audio clip
        fireSoundEffect.Play();
    }
}




