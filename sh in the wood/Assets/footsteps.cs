using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource foot1;
    public AudioSource foot2;

    public void playf1()
    {
        foot2.mute = true;
        foot2.Stop();
        foot1.mute = false;
        foot1.Play();
    }
    public void playf2()
    {
        foot1.mute = true;
        foot1.Stop();
        foot2.mute = false;
        foot2.Play();
    }
}
