using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // public AudioSource audioS;
    Vector2 movement;
    public float Mspeed = 10f;
    Animator animator;
    public static bool inputs = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (inputs)
        {
            animator.SetFloat("hD", movement.x);
            animator.SetFloat("vD", movement.y);
            animator.SetFloat("speed", movement.SqrMagnitude());
        }
        else
        {
            animator.SetFloat("speed", 0);
        }
        // if (movement.x != 0 || movement.y != 0)
        // {
        //     audioS.Play();
        // }
        // // else
        // // {
        // //     audioS.Stop();
        // // }

    }
    private void FixedUpdate()
    {
        if (inputs)
        {
            rb.MovePosition(rb.position + movement * Mspeed * Time.fixedDeltaTime);
        }
    }
}
