using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textTrig : MonoBehaviour
{
    public GameObject text;
    public GameObject newText;
    // public float time = 1f;
    private bool happend = false;
    private void Awake()
    {
        happend = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!happend)
            {
                text.SetActive(true);
                StartCoroutine(textDisper(5));
            }
        }

    }
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {

    //     }

    // }
    // private void OnTriggerStay2D(Collider2D other)
    // {
    //     if (!happend)
    //     {
    //         if (other.CompareTag("Player"))
    //         {
    //             text.SetActive(true);
    //         }
    //     }

    // }
    IEnumerator textDisper(float time)
    {
        yield return new WaitForSeconds(time);
        text.SetActive(false);
        happend = true;
        StartCoroutine(nextText());
    }
    IEnumerator nextText()
    {
        text.SetActive(false);
        newText.SetActive(true);
        yield return new WaitForSeconds(5);
        newText.SetActive(false);
    }
}
