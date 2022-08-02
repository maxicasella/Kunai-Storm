using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    bool _menu = false;
    public GameObject menuPausa;
    public PlayerAttack _playerC;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_menu)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Pause()
    {
        _playerC.enabled = false;
        _menu = true;
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }

    public void Continue()
    {
        _playerC.enabled = true;
        _menu = false;
        Time.timeScale = 1f;
        menuPausa.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
