using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText;
    private void Start()
    {
        ValueText.text = PersistentManagerScript.Instance.Value.ToString();
    }
    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Scenes/Singleton_2/1stScene");
        PersistentManagerScript.Instance.Value++;
    }
    
    public void GoToSecondScene()
    {   SceneManager.LoadScene("Scenes/Singleton_2/2ndScene");
        PersistentManagerScript.Instance.Value++;
    }
}
