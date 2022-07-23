using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private int poolSize = 5;
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
        
    }
}
