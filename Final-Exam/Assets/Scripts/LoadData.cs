using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    public Text UserNameBox;
    public Text PasswordBox;

    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("username");
        PasswordBox.text = PlayerPrefs.GetString("Password");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("username");
        PlayerPrefs.DeleteKey("Password");
        SceneManager.LoadScene("FirstScene");
    }
}
