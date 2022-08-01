using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionRange : MonoBehaviour
{
    public Animator enemies;
    public Transform player;
    public Transform soldier;
    public SpriteRenderer spriteRenderer;

    public bool isMove;

    private void Start()
    {
        isMove = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerMovement movement = collision.GetComponent<PlayerMovement>();

        isMove = false;

        enemies.SetBool("Attack", true);
        enemies.SetBool("Caminata", false);
        
        if (spriteRenderer.flipX == false)
        {

            if (movement.movizq == true)
            {
                spriteRenderer.flipX = true;
            }

        }
        else
        {
            if (movement.movder == true)
            {
                spriteRenderer.flipX = false;
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {        
        enemies.SetBool("Attack", false);
        enemies.SetBool("Caminata", true);
        isMove = true;
           
    }
}
