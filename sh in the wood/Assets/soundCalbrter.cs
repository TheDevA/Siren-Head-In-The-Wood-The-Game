using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCalbrter : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = settingControler.volume;
    }

}
