using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    public Text scoreText;
    public Text missedText;
    public Text highScoreText;

    private void Awake()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
        missedText.text = "Words missed: " + WordDisplay.MissedWords.ToString();
        highScoreText.text = "High Score: " + WordDisplay.HighScore.ToString();
    }
    private void Update()
    {
        scoreText.text = "Score: " + WordDisplay.Score.ToString();
        missedText.text = "Words missed: " + WordDisplay.MissedWords.ToString();
        highScoreText.text = "High Score: " + WordDisplay.HighScore.ToString();
    }
}