using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FuelCanCounter : MonoBehaviour
{
    public static FuelCanCounter instance;
    public TMP_Text FuelText;
    public TMP_Text FuelTextSummary;
    public int currentFuel = 0;
  //  public Text FuelCanCollected;
   // private int FuelNum;
    
    void Awake()
    {
        instance = this;
    }

// Start is called before the first frame update
void Start()
    {
       FuelText.text = currentFuel.ToString();
       FuelTextSummary.text = currentFuel.ToString();
    }
    // Update is called once per frame
     public void IncreaseFuelCan(int v)
    {
        currentFuel += v;
        FuelText.text = currentFuel.ToString();
        FuelTextSummary.text = currentFuel.ToString();
    }
}
