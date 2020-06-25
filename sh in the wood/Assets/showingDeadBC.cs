using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showingDeadBC : MonoBehaviour
{
    public GameObject text;
    public GameObject texte;
    public GameObject whh;
    public GameObject goback;
    public Animator animator;
    private bool doiWork = false;
    private bool showtext = true;
    private bool displaytext = true;
    private void Start()
    {
        goback.SetActive(false);
        whh.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            displaytext = false;
            palyanim();
        }
    }
    void palyanim()
    {

        if (doiWork)
        {
            doiWork = false;
            texte.SetActive(false);
            animator.SetBool("ohfuck", true);

            if (showtext == true)
            {
                text.SetActive(true);
                showtext = false;
            }
            StartCoroutine(closeanim());
        }
    }
    IEnumerator closeanim()
    {
        yield return new WaitForSeconds(5);

        animator.SetBool("ohfuck", false);
        text.SetActive(false);
        goback.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        doiWork = true;
        whh.SetActive(false);

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        doiWork = false;
        texte.SetActive(false);
        if (displaytext)
        {
            whh.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        whh.SetActive(false);
        if (displaytext)
        {

            texte.SetActive(true);
        }
    }
}
