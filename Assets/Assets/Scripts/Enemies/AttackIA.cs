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
           
        }

        if (mySprite.flipX == false)
        {
            if (movement.movder == true)
            {
                mySprite.flipX = true;
            }
        }
        else
        {
            if (movement.movizq == true)
            {
                mySprite.flipX = false;
            }
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        PlayerMovement movement = collision.GetComponent<PlayerMovement>();

        if (mySprite.flipX == false)
        {
            if (movement.movder == true)
            {
                mySprite.flipX = true;
            }
        }
        else
        {
            if (movement.movizq == true)
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
