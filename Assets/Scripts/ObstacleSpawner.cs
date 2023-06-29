using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
   [SerializeField] private GameObject[] obstaclePrefabs; // Array of obstacle prefabs to randomly spawn
   [SerializeField] private float initialSpawnInterval = 2f; // Initial time interval between each spawn
   [SerializeField] private float minSpawnInterval = 0.5f; // Minimum time interval between spawns
   [SerializeField] private float spawnIntervalDecrease = 0.1f; // Amount of time interval decrease per spawn
   [SerializeField] private BoxCollider2D spawnArea; // BoxCollider2D defining the spawn area
   [SerializeField] private float obstacleSpeed = 5f; // Fixed downward speed for the spawned obstacles

    private float currentSpawnInterval; // Current spawn interval

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        // Start spawning obstacles
        StartCoroutine(SpawnObstacles());
    }

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            // Generate a random position within the spawn area bounds
            Vector2 spawnPosition = GetRandomSpawnPosition();

            // Randomly select an obstacle prefab from the array
            GameObject obstaclePrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

            // Instantiate the selected obstacle prefab at the spawn position
            GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

            // Set the downward velocity for the obstacle
            Rigidbody2D obstacleRb = obstacle.GetComponent<Rigidbody2D>();
            if (obstacleRb != null)
            {
                obstacleRb.velocity = new Vector2(0f, -obstacleSpeed);
            }

            // Destroy the obstacle after a certain time (e.g., 5 seconds)
            Destroy(obstacle, 5f);

            // Decrease the spawn interval
            currentSpawnInterval -= spawnIntervalDecrease;
            currentSpawnInterval = Mathf.Max(currentSpawnInterval, minSpawnInterval);

            // Wait for the specified spawn interval before spawning the next obstacle
            yield return new WaitForSeconds(currentSpawnInterval);
        }
    }

    private Vector2 GetRandomSpawnPosition()
    {
        Bounds bounds = spawnArea.bounds;

        // Generate a random position within the bounds of the spawn area
        float spawnX = Random.Range(bounds.min.x, bounds.max.x);
        float spawnY = Random.Range(bounds.min.y, bounds.max.y);

        return new Vector2(spawnX, spawnY);
    }
}
