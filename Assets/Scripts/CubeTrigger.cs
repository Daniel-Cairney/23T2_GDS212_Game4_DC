using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeTrigger : MonoBehaviour
{
    public TimeManager timerManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player enters the cube trigger, perform necessary actions here
            SceneManager.LoadScene("GameOverScene");
            Debug.Log("Player entered the cube trigger!");
        }
    }
}
