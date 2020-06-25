using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtonormal : MonoBehaviour
{
    public GameObject startText;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement.inputs = true;
        startText.SetActive(true);
        StartCoroutine(hideText());

    }
    IEnumerator hideText()
    {
        yield return new WaitForSeconds(10);
        startText.SetActive(false);
    }

}
