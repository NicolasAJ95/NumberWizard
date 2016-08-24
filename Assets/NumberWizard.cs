using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // Use this for initialization
    int max;
    int min;
    public int guess;
    int maxGuessesAllowed = 10;

    public Text text;

    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        max += 1;
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
        text.text = "";
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}