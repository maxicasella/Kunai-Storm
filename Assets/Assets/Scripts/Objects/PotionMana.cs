using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionMana : MonoBehaviour
{
    public float recupMana;
    public AudioSource audioMana;
    public GameObject particulas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerAttack playerMana = collision.GetComponent<PlayerAttack>();

        if (playerMana !=null)
        {
            audioMana.Play();
            Instantiate(particulas, transform.position, Quaternion.identity);
            playerMana.PotionMana(recupMana);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
