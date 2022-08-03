using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField] AudioSource _audio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats lvlkey = collision.GetComponent<PlayerStats>();
        if(lvlkey!=null)
        {
            _audio.Play();
            lvlkey.Key();
            Destroy(this.gameObject,0.5f);
        }
        
    }
}
