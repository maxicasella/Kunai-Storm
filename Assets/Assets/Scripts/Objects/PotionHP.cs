using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionHP : MonoBehaviour
{
    public float recupHP;
    public AudioSource hpPotion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats playerHp = collision.GetComponent<PlayerStats>();

        if (playerHp != null)
        {
            hpPotion.Play();
            playerHp.PotionHp(recupHP);
            Destroy(this.gameObject, 0.5f);

        }
    }
}
