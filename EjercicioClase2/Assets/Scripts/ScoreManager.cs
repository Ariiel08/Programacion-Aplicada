using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
    int _currentScore = 0;
    private readonly static ScoreManager _instance = new ScoreManager();

    public int IncrementScore()
    {
        _currentScore++;
        return _currentScore;
    }

    public static ScoreManager Instance
    {
        get
        {
            return _instance;
        }
    }
}
