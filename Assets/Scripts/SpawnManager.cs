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
    private float spawnPosZ = 80;

    private ScoreManager scoreControllerScript;
    private float fastRepeatRate = 0.5f; // Velocidade maior quando score >= 15
    private bool isFastSpawning = false; // Para evitar reiniciar o spawn repetidamente

    void Start()
    {
        playControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        scoreControllerScript = GameObject.Find("ScoreDisplay").GetComponent<ScoreManager>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        if (scoreControllerScript.score >= 15 && !isFastSpawning)
        {
            isFastSpawning = true; // Evita chamadas repetidas
            CancelInvoke("SpawnObstacle");
            InvokeRepeating("SpawnObstacle", 0f, fastRepeatRate);
        }
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
