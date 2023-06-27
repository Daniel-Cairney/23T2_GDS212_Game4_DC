using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isTimerRunning = true;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            float elapsedTime = Time.time - startTime;
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);
            string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
            timerText.text = timerString;
        }
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}
