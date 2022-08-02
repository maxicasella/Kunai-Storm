using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoFinalLvl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      PlayerStats player = collision.GetComponent<PlayerStats>();
        if (player != null)
        {
            SceneManager.LoadScene(8);
        }
       
    }
}
