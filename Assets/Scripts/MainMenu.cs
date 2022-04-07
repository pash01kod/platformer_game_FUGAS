using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Levels()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void AddPlayer()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void Result()
    {
        SceneManager.LoadScene("Standings");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
