using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    Text counterText;
    //public int points;

    void Start()
    {
        counterText = GetComponent<Text>();
        Coins.totalCoins = PlayerPrefs.GetInt("Points", 0);
        
    }

    void Update()
    {
        if (counterText.text != Coins.totalCoins.ToString())
        {
            counterText.text = Coins.totalCoins.ToString();
        }
    }
}