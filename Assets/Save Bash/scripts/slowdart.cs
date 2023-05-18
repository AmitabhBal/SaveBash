using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowdart : MonoBehaviour
{
    public GameObject element;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 30;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            int r = UnityEngine.Random.Range(1, 3);
            if (r==1)
            {
                randX = 150f;
            }
            else
            {
                randX = -150f;
            }
            randY = UnityEngine.Random.Range(4.20f, -4.20f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(element, whereToSpawn, Quaternion.identity);

        }

    }
}
