using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endofTrans : MonoBehaviour
{
    public GameObject text;

    public void end()
    {
        text.SetActive(true);
    }
}
