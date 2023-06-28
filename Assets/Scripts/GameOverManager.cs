using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameOverManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private void Start()
    {
        // Get the stored timer value from GameManager or PlayerPrefs
        float score = GameManager.GetScore();

        // Display the score on the UI text
        scoreText.text = "Score: " + score.ToString("F2");

        // Reset the stored timer value for the next game
        GameManager.ResetScore();
    }
}
