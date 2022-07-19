using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiMov : MonoBehaviour
{
    Vector3 mouseAim;
    Rigidbody2D bulletRb;
    public float bulletForce;
    PlayerStats _player;
    private float _damage = 10;
  

    void Start()
    {
        _damage = 10;
        _player = GetComponent<PlayerStats>();

       
        //Disparo hacia el click

        bulletRb = GetComponent<Rigidbody2D>();

        mouseAim = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 dir = mouseAim - transform.position;
        Vector3 rot = transform.position - mouseAim;

        bulletRb.velocity = new Vector2(dir.x, dir.y).normalized * bulletForce;
        float z = Mathf.Atan2(rot.y, rot.x) * Mathf.Rad2Deg;


    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    EnemyBase _enemy = collision.gameObject.GetComponent<EnemyBase>();
    //    if (_enemy)
    //    {
    //        _enemy.ReceiveDamage(_damage);
    //        Destroy(this.gameObject);
    //    }
    //}
}
