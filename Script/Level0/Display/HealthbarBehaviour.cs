using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarBehaviour : MonoBehaviour

{
   public HeroManager heroManager;
   public Image fillImage;
   private Slider slider;

    private void Awake()
    {
     slider = GetComponent<Slider>();
    }

    private void Update()
    {
        float fillValue = heroManager.health / heroManager.maxhealth;
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }  
        
        
        if(fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        else if(fillValue > slider.maxValue / 3)
            {
                fillImage.color = Color.green;
            }
        slider.value = fillValue;
    }

 
}