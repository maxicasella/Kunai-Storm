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

        enemies.SetBool("Attack", true);
        enemies.SetBool("Caminata", false);
        isMove = false;
        
        //if (player.position.x > 0)
        //{
        //    spriteRenderer.flipX = false;
        //}
        //else if(player.position.x < 0)
        //{
        //    spriteRenderer.flipX = true;
        //}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isMove = true;
        enemies.SetBool("Attack", false);
        enemies.SetBool("Caminata", true);
        //if (soldier.position.x < 0)
        //{
        //    spriteRenderer.flipX = false;
        //}
        //else if (soldier.position.x > 0)
        //{
        //    spriteRenderer.flipX = true;
        //}
       
    }
}
