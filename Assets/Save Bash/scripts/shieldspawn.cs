using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldspawn : MonoBehaviour
{
    public GameObject element;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 43;
    float nextSpawn = 0.0f;

     

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            int r = UnityEngine.Random.Range(1, 3);
            if (r == 1)
            {
                randX = 100f;
            }
            else
            {
                randX = -100f;
            }
            randY = UnityEngine.Random.Range(4.20f, -4.20f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(element, whereToSpawn, Quaternion.identity);
        }

    }
}
