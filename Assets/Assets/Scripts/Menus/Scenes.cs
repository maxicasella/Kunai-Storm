using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public Animator Fade;
    public string Scene;

    public void NextSecene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        Fade.SetTrigger("NextScene");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(Scene);
    }
}

