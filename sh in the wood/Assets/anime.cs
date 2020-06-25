using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour
{
    public Transform player;
    public Animator animator;
    public GameObject targetcol;

    private void FixedUpdate()
    {
        if (player.position.y < transform.position.y)
        {
            animator.SetBool("tf", true);
            targetcol.SetActive(false);
        }
        else if (player.position.y > transform.position.y)
        {
            animator.SetBool("tf", false);

        }
    }
}
