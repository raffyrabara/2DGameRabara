using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButtonManager : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject SoundOff;
    public GameObject AudioManage;
    // Start is called before the first frame update
    void Start()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundOnIcon()
    {
        //LaserManager.LazerSoundEffect.Stop();
        SoundOff.SetActive(true);
        SoundOn.SetActive(false);
        AudioManage.SetActive(false);
    }
    public void SoundOffIcon()
    {
        //LaserManager.LazerSoundEffect.Play();
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        AudioManage.SetActive(true);
    }
}
