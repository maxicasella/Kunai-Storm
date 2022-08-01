using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIA : MonoBehaviour
{
    public bool targetPlayer;
    [SerializeField] BossMovement _bossMov;
    [SerializeField] Transform _playerT;
    [SerializeField] SpriteRenderer mySprite;
    [SerializeField] Animator _myAnim;
    [SerializeField] VisionRange _move;


    public void Start()
    {
        targetPlayer = false;

    }

    private void Update()
    {
         if(targetPlayer == false)
        {
            _move.isMove = false;
           
        }
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
            _move.isMove = true;
            _myAnim.SetBool("Caminata", true);
            _myAnim.SetBool("Iddle", false);

        }

    }

    public void OnTriggerExit2D(Collider2D collider)
    {
        PlayerStats player = collider.GetComponent<PlayerStats>();

        if (player != null)
        {
            targetPlayer = false;
            _move.isMove = false;
            _myAnim.SetBool("Caminata", false);
            _myAnim.SetBool("Iddle", true);
            
        }

    }

    public void ChangeTarget()
    {
        
        if (targetPlayer == true)
        {
            _bossMov.targetPoint = _playerT;
            _move.isMove = true;
                        
        }
        else
        {
            _bossMov.targetPoint = _bossMov.iddleT;
            _move.isMove = false;
        }
   
    }
}

