using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoDeVision : MonoBehaviour
{
    private Enemy1 _enemy;

    private void Start()
    {
        _enemy = GetComponentInParent<Enemy1>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision && collision.name == "Player")
        {
            _enemy.ActivateAttack();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision && collision.name == "Player")
        {
            _enemy.DesactivateAttack();
        }
    }
}
