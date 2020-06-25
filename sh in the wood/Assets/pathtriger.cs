using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathtriger : MonoBehaviour
{
    public GameObject text;
    public GameObject oldText;
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
                oldText.SetActive(false);
                text.SetActive(true);
                StartCoroutine(hidetext());
                happend = true;
            }
        }
    }
    IEnumerator hidetext()
    {
        yield return new WaitForSeconds(10f);
        text.SetActive(false);
    }
}
