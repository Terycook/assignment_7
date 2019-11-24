using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        WordDisplay.Score = 0;
        WordDisplay.MissedWords = 0;
        SceneManager.LoadScene("Intro");

    }

    public void ExitGame()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
    }
}