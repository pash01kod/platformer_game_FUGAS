using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Standings : MonoBehaviour
{
    public int score = 0;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Highscore"))
        {
            score = PlayerPrefs.GetInt("Highscore");
        }
        PlayerPrefs.SetInt("Highscore", score);
    }

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        string name = PlayerPrefs.GetString("Player");
        gt.text = name + "'s score is" + score + " points";
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
