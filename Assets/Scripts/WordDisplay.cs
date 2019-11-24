using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

	public Text text;
    public Slider WordSpeed;
    public static Text ScoreText;
    public AudioClip mySound;
    private AudioSource removedSound;

    public static int Score = 0;
    public static int HighScore = 0;
    public static int MissedWords = 0;

	public static float fallSpeed = 1f;
    

	public void SetWord(string word)
	{
        text.text = word;
        text.color = KeepData.ColorOption;
    }

	public void RemoveLetter()
	{
        removedSound.PlayOneShot(mySound);
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
        
	}

	public void RemoveWord()
	{
        
        Score++;
        if (Score > HighScore)
        {
            HighScore = Score;
        }
        
        Destroy(gameObject);
        
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

    public void Word_Speed()
    {
        fallSpeed = WordSpeed.value;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "StopPoint")
        {
            MissedWords++;
            

        }
    }

    private void Awake()
    {
        removedSound = GetComponent<AudioSource>();

    }

}