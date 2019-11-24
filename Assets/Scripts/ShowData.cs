using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ShowData : MonoBehaviour
{
    public Text NameText;
    
    public Text SliderSpeedText;
    
    
    

    private void Update()
    {
        NameText.text = "Name: " + KeepData.PlayerName;
        
        SliderSpeedText.text = "Speed: " + WordDisplay.fallSpeed.ToString();

  

    }

}