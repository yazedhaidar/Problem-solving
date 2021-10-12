using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int currentScore = 0;
    private static int highScore;

    #region Singleton

    private static ScoreController _instance = null;

    public static ScoreController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreController>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: ScoreController not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }


   

    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment;

        
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }

    private void Start()
    {
        ResetCurrentScore();
    }
}
