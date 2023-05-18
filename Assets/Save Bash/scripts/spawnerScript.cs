using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            float minX = -8.2f;
            float maxX = -3.16f;
            nextSpawn = Time.time + spawnRate;
            int r = UnityEngine.Random.Range(1, 2);
            randX = UnityEngine.Random.Range(minX, maxX);
            randY = UnityEngine.Random.Range(4.20f, -4.20f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
        
    }
}
