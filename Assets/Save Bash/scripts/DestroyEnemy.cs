using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject effect;
    

   
    void OnMouseDown()
    {
       
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
