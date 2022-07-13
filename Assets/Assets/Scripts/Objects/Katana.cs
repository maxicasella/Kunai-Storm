using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    public bool katanaRecollectable = true;
    public AudioSource katanaPlay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerAttack _katanaRecolectable = collision.GetComponent<PlayerAttack>();

        if (_katanaRecolectable !=null)
        {
            //katanaPlay.Play();
            _katanaRecolectable.Katana(katanaRecollectable);
            Destroy(this.gameObject, 0.5f);
        }
    }
}
