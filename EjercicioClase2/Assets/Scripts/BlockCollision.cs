using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    public TextMesh score;
    //int _currentScore = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(score != null)
        {
            Destroy(other.gameObject);
            score.text = ScoreManager.Instance.IncrementScore().ToString();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
