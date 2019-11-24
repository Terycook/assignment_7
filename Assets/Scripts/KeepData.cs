using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KeepData : MonoBehaviour
{
    // STATIC so they are preserved between classes
    public static string PlayerName;
    public static float PlayingSpeed;
    //public static string score;
    public static Color ColorOption = Color.white; 

    public InputField PlayerNameInput;
    public Slider speedSlider;
    //public Text PlayerScore;
    public Dropdown ColorOfWord;

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspecto
    public Text playingSpeedText;
    //public Text ShowPlayerScore;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }


    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }

   

    public void SetColorOfWord()    {        switch (ColorOfWord.value)        {            case 1:                ColorOption = Color.black;                break;            case 2:                ColorOption = Color.green;                break;            case 3:                ColorOption = Color.yellow;                break;

            default:                ColorOption = Color.blue;                break;        }    }



}