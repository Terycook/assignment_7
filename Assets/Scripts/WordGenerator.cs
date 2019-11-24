
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = File.ReadAllLines("/Users/terycook/Documents/Documents/game_programming/assignment_7/assignment_7/Assets/wordFolder/wordsDD.txt");

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
    
}