using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddPlayer : MonoBehaviour
{
    public InputField InputField;

    public void AddName()
    {
        PlayerPrefs.SetString("Player", InputField.text);
        SceneManager.LoadScene(7);
    }
}
