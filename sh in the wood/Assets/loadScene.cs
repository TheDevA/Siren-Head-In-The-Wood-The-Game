using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public string SceneName;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // for (float i = AudioManager.lvolume; i > 0; i -= 0.01f)
            // {
            //     AudioManager.lvolume = i;
            //     // Debug.Log(i);
            // }
            // StartCoroutine(loadnextScene());
            SceneManager.LoadScene(SceneName);
        }
    }
    // IEnumerator loadnextScene()
    // {
    //     yield return SceneManager.LoadSceneAsync(SceneName);
    // }
}
