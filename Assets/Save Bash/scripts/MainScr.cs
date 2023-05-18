using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScr : MonoBehaviour
{
    public GameObject effect;
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public int health = 5;
    int playerlayer, enemylayer;
    bool coroutineAllowed = true;
    public GameObject Border1;
    public GameObject Border2;
    public GameObject modeOn;
    public GameObject shield0, shield1, shield2;
    
    
    
    Color color;
    Renderer rend;
    void Start()
    {
        playerlayer = this.gameObject.layer;
        enemylayer = LayerMask.NameToLayer("Enemy");
        Physics2D.IgnoreLayerCollision(playerlayer, enemylayer, false);
        heart1 = GameObject.Find("heart1");
        heart2 = GameObject.Find("heart2");
        heart3 = GameObject.Find("heart3");
        heart4 = GameObject.Find("heart4");
        heart5 = GameObject.Find("heart5");
        Border1 = GameObject.Find("Border0");
        Border2 = GameObject.Find("Border1");
        modeOn = GameObject.Find("ModeB");
        Border1.gameObject.SetActive(false);
        Border2.gameObject.SetActive(false);
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
        shield0.gameObject.SetActive(false);
        shield1.gameObject.SetActive(false);
        shield2.gameObject.SetActive(false);

        rend = GetComponent<Renderer>();
        color = rend.material.color;
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            health -= 1;
            switch (health)
            {
                case 4:
                    heart5.gameObject.SetActive(false);
                    if (coroutineAllowed)
                    {
                        StartCoroutine("Immortal");
                    }
                    break;
                case 3:
                    heart4.gameObject.SetActive(false);
                    if (coroutineAllowed)
                    {
                        StartCoroutine("Immortal");
                    }
                    break;
                case 2:
                    heart3.gameObject.SetActive(false);
                    if (coroutineAllowed)
                    {
                        StartCoroutine("Immortal");
                    }
                    break;
                case 1:
                    heart2.gameObject.SetActive(false);
                    if (coroutineAllowed)
                    {
                        StartCoroutine("Immortal");
                    }
                    break;
                case 0:
                    heart1.gameObject.SetActive(false);
                    if (coroutineAllowed)
                    {
                        StartCoroutine("Immortal");
                    }
                    break;


            }
            
            if (health < 1)
            {
                
                
                StartCoroutine("WaitForSecs");
                SceneManager.LoadScene("Over");




            }




        }
        if (col.gameObject.tag.Equals("Boost"))
        {
            Border1.gameObject.SetActive(true);
            Border2.gameObject.SetActive(true);
            modeOn.gameObject.SetActive(true);
        }
        if (col.gameObject.tag.Equals("shield"))
        {
            shield0.gameObject.SetActive(true);
            shield1.gameObject.SetActive(true);
            shield2.gameObject.SetActive(true);
        }
    }
    IEnumerator Immortal()
    {
        coroutineAllowed = false;
        Physics2D.IgnoreLayerCollision(playerlayer, enemylayer, true);
        color.a = 0.5f;
        rend.material.color = color;
        yield return new WaitForSeconds(3f);
        Physics2D.IgnoreLayerCollision(playerlayer, enemylayer, false);
        color.a = 1f;
        rend.material.color = color;
        coroutineAllowed = true;

    }
    IEnumerator WaitForSecs()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        



    }
}
