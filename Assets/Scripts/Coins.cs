using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int totalCoins = 0;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.tag == "Player")
        {
            totalCoins++;
            PlayerPrefs.SetInt("Points", totalCoins);
            Debug.Log("You currently have " + Coins.totalCoins + " Coins.");
            Destroy(gameObject);
        }
    }
}