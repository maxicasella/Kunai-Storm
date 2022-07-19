using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorEnemy : MonoBehaviour
{
    private Enemy1 _movement; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision)
        {
            _movement = collision.GetComponent<Enemy1>();
            if (_movement)
            {
                _movement.ChangeRotation();
            }
        }
    }
}
