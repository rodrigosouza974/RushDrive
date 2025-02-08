using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    private Vector3 spawnPos = new Vector3(40, 0, 0);
    private float startDelay = 1;
    private float repeatRate = 1;
    private PlayerController playControllerScript;

    private float spawnLimitXLeft = 10;
    private float spawnLimitXRight = 10;
    private float spawnPosY = 0;
    private float spawnPosZ = 50;

    void Start()
    {
        playControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
    }
    
    void SpawnObstacle()
    {
        if (playControllerScript.gameOver == false)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);

        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos,
         obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
