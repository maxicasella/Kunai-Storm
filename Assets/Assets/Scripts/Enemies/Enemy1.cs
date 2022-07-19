using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Base_Enemy
{
    //Auxiliares
    public float timeToChangeState;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = baseLife;
        currentState = states.IDLE;
    }

    // Update is called once per frame
    void Update()
    {
        ArtificialUpdate();
        if (currentState != states.Death && currentState != states.Attack)
        {
            if (timeToChangeState <= 0 )
            {
                currentState = (states)Random.Range(0, 2);
                timeToChangeState = Random.Range(0, 1);
            }
            else if (timeToChangeState > 0)
            {
                timeToChangeState -= Time.deltaTime;
            }
        }
    }

    public void ChangeRotation()
    {
        speed *= -1;
        if (mySprite.flipX)
        {
            mySprite.flipX = false;
        }
        else
        {
            mySprite.flipX = true;
        }
        currentState = states.Walk;
    }

    public void ActivateAttack()
    {
        currentState = states.Attack;
    }

    public void DesactivateAttack()
    {
        currentState = (states)Random.Range(0,2);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.IsTouchingLayers(7))
        {
            _isGrounded = true;
        }
        if (collision.GetComponent<PlayerStats>() && this.name == "Ghost")
        {
            collision.GetComponent<PlayerStats>().UpdateHP(damage);
        }
    }*/

    public void ReceiveDamage(float damage)
    {
        currentLife -= damage;
        if(currentLife <= 0)
        {
            currentState = states.Death;
            ArtificialUpdate();
        }
    }
}
