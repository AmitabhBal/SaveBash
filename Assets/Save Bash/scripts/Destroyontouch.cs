using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyontouch : MonoBehaviour
{
    public GameObject effect;
    void OnMouseDown()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
