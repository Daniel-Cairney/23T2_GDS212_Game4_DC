using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static float score;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void SetScore(float value)
    {
        score = value;
    }

    public static float GetScore()
    {
        return score;
    }

    public static void ResetScore()
    {
        score = 0f;
        
    }

   
}
