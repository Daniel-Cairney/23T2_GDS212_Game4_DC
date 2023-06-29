using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    //[SerializeField] private AudioClip birdDeath;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Play();
                
            // Player enters the cube trigger, perform necessary actions here
            SceneManager.LoadScene("GameOverScene");
            Debug.Log("Player entered the cube trigger!");
            ScoreManager.SetScore(0);
        }
    }
}
