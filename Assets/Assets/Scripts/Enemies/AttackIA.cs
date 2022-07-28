using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackIA : MonoBehaviour
{
    public bool targetPlayer;
    [SerializeField] EnemiesIA enemieMov;
    [SerializeField] Transform _playerT;
    [SerializeField] SpriteRenderer mySprite;


    public void Start()
    {
        targetPlayer = false;
    }

    public void FixedUpdate()
    {

        ChangeTarget();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats player = collision.GetComponent<PlayerStats>();
        PlayerMovement movement = collision.GetComponent<PlayerMovement>();

        if (player != null)
        {
            targetPlayer = true;
            if (movement.movder)
            {
                mySprite.flipX = true;

                if (mySprite.flipX == true && movement.movizq == true)
                {
                    mySprite.flipX = false;
                }
               
            }

            if (movement.movizq)
            {
                mySprite.flipX = false;
            }   
            
        }

    }
   

    public void OnTriggerExit2D(Collider2D collider)
    {
        PlayerStats player = collider.GetComponent<PlayerStats>();

        if (player != null)
        {
            targetPlayer = false;
        }

    }

    public void ChangeTarget()
    {

        if (targetPlayer == true)
        {
            enemieMov.targetPoint = _playerT;
        }

       
    }
}
