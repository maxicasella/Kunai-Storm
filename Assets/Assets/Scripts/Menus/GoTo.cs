using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoTo : MonoBehaviour
{
    public void Go (string scenes)
    {
        SceneManager.LoadScene(scenes);
    }
}
