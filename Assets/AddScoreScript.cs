using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreScript : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    public ScoreManager scoreManager;

    void Start()
    {
        currentScore = 0;
    }
    void Update()
    {
        scoreText.text = currentScore.ToString();
    }
    public void incScore(int scores)
    {
        currentScore += scores;
    }
    public void addScore()
    {
        scoreManager.AddScore(new global::Score(name: PlayerPrefs.GetString("playerName"), score: currentScore));
    }

}
