using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclesPrefabs;
    public float obstacleSpawnTime = 2f;
    public float obstacleSpeed = 1f;
    private float timeUntilObstacleSpawn;

    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilObstacleSpawn += Time.deltaTime;

        if (timeUntilObstacleSpawn > obstacleSpawnTime)
        {
            Spawn();
            timeUntilObstacleSpawn = 0f;
        }
    }

    private void Spawn()
    {
        GameObject obstacletoSpawn = obstaclesPrefabs[Random.Range(0, obstaclesPrefabs.Length)];

        GameObject spawnedObstacles = Instantiate(obstacletoSpawn, transform.position, Quaternion.identity);
        Rigidbody2D obstacleRB = spawnedObstacles.GetComponent<Rigidbody2D>();
        obstacleRB.velocity = Vector2.left * obstacleSpeed; 
    }
}
