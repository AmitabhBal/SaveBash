using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Vector2 targetPosition;

    public float speed = 1.75f;
    
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = NewBehaviourScript.target();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
       
    }
    
    static Vector2 target()
    {
        return new Vector2(0, 0);
    }

}
