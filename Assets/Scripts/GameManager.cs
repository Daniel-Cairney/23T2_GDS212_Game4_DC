using UnityEngine;
using TMPro;

public static class GameManager
{
    private static float score;

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
