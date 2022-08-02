using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour
{
    public int activeScene;
    private void Awake()
    {
        GameObject[] menuMusic = GameObject.FindGameObjectsWithTag("MusicMenu");
        var scene = SceneManager.GetActiveScene();

        if (menuMusic.Length>1)
        {
            Destroy(this.gameObject);
        }

     

        DontDestroyOnLoad(this.gameObject);
 
    }

    private void Start()
    {
        OnLevelWasLoaded(activeScene);

        if (activeScene < 5)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        else if (activeScene >= 5)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        activeScene = level;
    }
}
