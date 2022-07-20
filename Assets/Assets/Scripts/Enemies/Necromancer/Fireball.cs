using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    [SerializeField] float _force;
    public float dmg;
    [SerializeField] float _velocityX;
    [SerializeField] float _velocityY;
    [SerializeField] Transform _target;

    Rigidbody2D _myRb;
    Vector2 _dir;

    private void Start()
    {
        _myRb = GetComponent<Rigidbody2D>();

        Vector2 targetPos = _target.position;
        _dir = targetPos - (Vector2)transform.position;

        
    }
    private void FixedUpdate()
    {
        _myRb.AddForce(_dir * _force);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats pjStats = collision.GetComponent<PlayerStats>();

        if (pjStats != null)
        {
            pjStats.Damage(dmg);
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
