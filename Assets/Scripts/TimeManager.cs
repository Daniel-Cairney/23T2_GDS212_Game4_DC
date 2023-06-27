using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class TimeManager : MonoBehaviour
{
    public TMP_Text timeText;
    private static float currentTime;
    private static bool isTimerRunning = true;

    private void Start()
    {
        currentTime = 0f;
        isTimerRunning = true;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime += Time.deltaTime;
            timeText.text = "Time: " + currentTime.ToString("F2");
        }
    }

    public static float GetElapsedTime()
    {
        return currentTime;
    }

    public static void StopTimer()
    {
        isTimerRunning = false;
    }

    public static void ResetTimer()
    {
        currentTime = 0f;
        isTimerRunning = true;
    }

    public void GameOver()
    {
        StopTimer();
        SceneManager.LoadScene("GameOverScene");
    }
}
