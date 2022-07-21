using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    [SerializeField] Animator _myAnim;

    //private void OnTriggerStay2D(Collider other)
    //{
    //    _myAnim.SetBool("Iddle", false);
    //    _myAnim.SetBool("Attack", true);

    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        _myAnim.SetBool("Attack", false);
        _myAnim.SetBool("Iddle", true);
    }
}
