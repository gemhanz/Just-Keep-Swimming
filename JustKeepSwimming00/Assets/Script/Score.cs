using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public int highscore;
    public Text scoreDisplay;
    public Text highscoreDisplay;

    void Start()
    {
        highscoreDisplay.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        //highscoreDisplay.text = highscore.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscoreDisplay.text = score.ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }     
    }
}
