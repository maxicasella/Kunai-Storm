using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] menuMusic = GameObject.FindGameObjectsWithTag("MusicMenu");
        if (menuMusic.Length>1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
