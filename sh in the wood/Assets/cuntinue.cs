using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cuntinue : MonoBehaviour
{
    public Animator animator;
    public AudioSource audiop;
    bool startlowsound = false;
    private void Start()
    {
        StartCoroutine(ptc());
    }
    IEnumerator ptc()
    {
        yield return new WaitForSeconds(5);
        animator.SetBool("start", true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            animator.SetBool("start", false);
            animator.SetTrigger("exit");
        }
    }
    private void LateUpdate()
    {
        if (startlowsound)
        {

        }
    }
    public void loadnextScene()
    {
        for (float i = audiop.volume; i > 0; i -= 0.01f)
        {
            audiop.volume = i;
            // Debug.Log(i);
        }
        audiop.mute = true;
        audiop.Stop();
        startlowsound = true;
        if (startlowsound)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
