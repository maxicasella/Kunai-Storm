using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Enemy : MonoBehaviour
{
    //Estados
    public enum states { IDLE = 0, Walk, Attack, Death};

    //Estadisiticas
    public float            speed;
    public float            baseLife;
    public float            currentLife;
    public float            damage;
    public states           currentState;

    //Componentes
    public Rigidbody2D myRigidbody;
    public Transform target;
    public Animator myAnim;
    public SpriteRenderer mySprite;

    public void ArtificialUpdate()
    {
        switch (currentState)
        {
            case states.IDLE:
                IDLE();
                break;

            case states.Walk:
                Walking();
                break;

            case states.Attack:
                Attacking();
                break;

            case states.Death:
                Death();
                break;

            default:
                break;
        }
    }

    private void IDLE()
    {
        Debug.Log("IDLE");
        myAnim.SetBool("Walking", false);
        myAnim.SetBool("Attacking", false);
    }

    private void Walking()
    {
        Debug.Log("Walking");
        myAnim.SetBool("Walking", true);
        myAnim.SetBool("Attacking", false);
        myRigidbody.MovePosition(myRigidbody.position + (Vector2)transform.right * speed * Time.deltaTime);
    }

    private void Attacking()
    {
        Debug.Log("Attack");
        myAnim.SetBool("Walking", false);
        myAnim.SetBool("Attacking", true);
    }

    private void Death()
    {
        Debug.Log("Death");
        myAnim.SetBool("Death", true);
        Destroy(this.gameObject);
    }
}
