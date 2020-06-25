using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingControler : MonoBehaviour
{
    public AudioSource audioSource;
    public static float volume = 1;
    public void setv(float v)
    {
        audioSource.volume = v;
        volume = audioSource.volume;
    }
    public void setscreen(bool fscreen)
    {
        Screen.fullScreen = fscreen;
    }
}
