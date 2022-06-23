using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int _currentScore = 0;
    int _currentLives = 8;
    public TextMesh ScoreText;
    public TextMesh LivesText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = _currentScore.ToString();
        LivesText.text = _currentLives.ToString();
    }

    public void IncrementScore()
    {
        _currentScore++;
        ScoreText.text = _currentScore.ToString();
    }

    public void DecrementLives()
    {
        _currentLives--;
        LivesText.text = _currentLives.ToString();
    }

    public void IncrementLives()
    {
        _currentLives++;
        LivesText.text = _currentLives.ToString();
    }
}