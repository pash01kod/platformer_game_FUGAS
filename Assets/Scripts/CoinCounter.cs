using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    Text counterText;

    void Start()
    {
        counterText = GetComponent<Text>();
    }

    void Update()
    {
        if (counterText.text != Coins.totalCoins.ToString())
        {
            counterText.text = Coins.totalCoins.ToString();
        }
    }
}