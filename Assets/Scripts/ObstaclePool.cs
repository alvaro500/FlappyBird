using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private int poolSize = 5;
    [SerializeField] private float spawnTime = 2.5f;

    private float timeElapsed; //Guardar el tiempo que pasó desde la última aparición
    private int obstacleCount;
    private GameObject[] obstacles;
    

    // Start is called before the first frame update
    void Start()
    {
        obstacles = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            obstacles[i] = Instantiate(obstaclePrefab);
            obstacles[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnObstacle();
        }        
    }

    private void SpawnObstacle()
    {
        timeElapsed = 0f;
        obstacles[obstacleCount].SetActive(true);
        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }
    }
}
