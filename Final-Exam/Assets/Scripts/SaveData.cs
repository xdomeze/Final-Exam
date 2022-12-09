using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveData : MonoBehaviour
{
    public InputField textBox;
    public InputField textBox2;
    public void clickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        PlayerPrefs.SetString("Password", textBox2.text);
        SceneManager.LoadScene("SecondScene");
    }
}
