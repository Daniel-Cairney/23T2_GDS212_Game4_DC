using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class TimeManager : MonoBehaviour
{
    public TMP_Text timeText;
    public static float currentTime;
    public static bool isTimerRunning = true;
    [SerializeField] private GameObject timerManager;

    private void Start()
    {
        currentTime = 0f;
        isTimerRunning = true;
        timerManager.SetActive(false);
        Debug.Log("timerManager is " + timerManager.activeInHierarchy.ToString());
        Debug.Log(isTimerRunning + "Timer running");
        
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            //Debug.Log("Timer is Running");
            //currentTime += Time.deltaTime;
            //timeText.text = "Time: " + currentTime.ToString("F2");
            //ScoreManager.SetScore(currentTime);
            timeText.text = "Time: " + Time.timeSinceLevelLoad.ToString("F2");
            ScoreManager.SetScore(Time.timeSinceLevelLoad);
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
        timerManager.SetActive(true);
        SceneManager.LoadScene("GameOverScene");
        isTimerRunning = false;
    }
}
