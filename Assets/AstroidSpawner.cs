using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Transform playerTransform;
    public float spawnInterval = 3f;
    public float moveSpeed = 2f; // Vertical movement speed
    public float topY = 0.3f; // Top limit of movement
    public float bottomY = -0.5f; // Bottom limit of movement
    public float asteroidSpeed = 5f;

    private bool movingUp = true;

    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            float newY = transform.position.y;

            if (movingUp)
            {
                newY += moveSpeed * Time.deltaTime;
                if (newY >= topY)
                {
                    newY = topY;
                    movingUp = false;
                }
            }
            else
            {
                newY -= moveSpeed * Time.deltaTime;
                if (newY <= bottomY)
                {
                    newY = bottomY;
                    movingUp = true;
                }
            }

            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            // Spawn asteroid to the left
            Vector3 spawnPosition = transform.position + Vector3.left; // Spawn position slightly to the left of the spawner
            Instantiate(asteroidPrefab, spawnPosition, Quaternion.Euler(0, 0, 90)); // Spawn asteroid to the left

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
