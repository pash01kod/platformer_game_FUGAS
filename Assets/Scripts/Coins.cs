using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int totalCoins = 0;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Points"))
        {
            PlayerPrefs.SetInt("Points", 0);
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            PlayerPrefs.SetInt("Points", 0);
        }


        GetComponent<Collider2D>().isTrigger = true;

    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.tag == "Player")
        {
            totalCoins++;
            PlayerPrefs.SetInt("Points", totalCoins);
            
            Destroy(gameObject);
        }
    }
}