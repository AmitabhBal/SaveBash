using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public GameObject effect;
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("main"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            
           
            Destroy(gameObject);
            
        }
    }
    
}
