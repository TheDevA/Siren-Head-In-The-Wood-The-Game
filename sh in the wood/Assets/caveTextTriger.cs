using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caveTextTriger : MonoBehaviour
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
            text.SetActive(false);
            if (!happend)
            {

                newText.SetActive(true);
                StartCoroutine(textDisper(5));
            }
        }

    }
    IEnumerator textDisper(float time)
    {
        yield return new WaitForSeconds(5);
        newText.SetActive(false);
        happend = true;
    }
}
