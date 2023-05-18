using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncollision : MonoBehaviour
{
    public GameObject shield;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            shield.gameObject.SetActive(false);

        }
    }
}
