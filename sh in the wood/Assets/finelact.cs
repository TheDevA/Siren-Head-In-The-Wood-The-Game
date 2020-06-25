using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class finelact : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public AudioSource sh;
    public GameObject pp;
    public GameObject text;
    public GameObject oldtext;
    public GameObject fs;
    private AudioSource endsound;
    ChromaticAberration ca;
    LensDistortion lens;
    Bloom bloom;
    bool startcheks = false;
    private void Start()
    {
        endsound = fs.GetComponent<AudioSource>();
        PostProcessVolume v = pp.GetComponent<PostProcessVolume>();
        v.profile.TryGetSettings(out ca);
        v.profile.TryGetSettings(out lens);
        v.profile.TryGetSettings(out bloom);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerH") || other.CompareTag("PlayerR"))
        {
            oldtext.SetActive(false);
            text.SetActive(true);
            for (float i = sh.volume; i > 0; i -= 0.1f)
            {
                sh.volume = i;
            }
            sh.mute = true;
            sh.Stop();
            fs.SetActive(true);
            startcheks = true;
            playerMovement.inputs = false;
            spriteRenderer.flipX = true;
            StartCoroutine(carize());

            StartCoroutine(textDisper());
        }


    }
    IEnumerator textDisper()
    {
        yield return new WaitForSeconds(5);
        text.SetActive(false);
    }
    IEnumerator carize()
    {
        StartCoroutine(lensrize());
        StartCoroutine(blomrize());
        for (float i = 0.4f; i < 1; i += 0.001f)
        {
            yield return new WaitForSeconds(0.1f);
            // yield return null;
            ca.intensity.value = i;

        }
    }
    IEnumerator lensrize()
    {
        for (float i = 23f; i < 50; i += 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            // yield return null;
            lens.intensity.value = i;
        }
    }
    IEnumerator blomrize()
    {
        for (float i = 0.4f; i < 20; i += 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            // yield return null;
            bloom.intensity.value = i;
        }
    }
    private void FixedUpdate()
    {
        if (startcheks && !endsound.isPlaying)
        {
            SceneManager.LoadScene("MainMinue");
        }
    }



}
