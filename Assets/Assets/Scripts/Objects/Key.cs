using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats lvlkey = collision.GetComponent<PlayerStats>();
        if(lvlkey!=null)
        {
            lvlkey.Key();
            Destroy(this.gameObject);
        }
        
    }
}
