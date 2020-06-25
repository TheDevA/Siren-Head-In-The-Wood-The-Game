using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainM : MonoBehaviour
{
    public void playBtn()
    {
        SceneManager.LoadScene("Story");
    }
    public void exitBtn()
    {
        Application.Quit();
    }
}
