using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int _currentScore = 0;
    public TextMesh ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = _currentScore.ToString();
    }

    public void IncrementScore()
    {
        _currentScore++;
        ScoreText.text = _currentScore.ToString();
    }
}
