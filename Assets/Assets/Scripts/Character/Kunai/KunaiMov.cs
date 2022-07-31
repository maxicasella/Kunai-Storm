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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemieStats enemieHP = collision.GetComponent<EnemieStats>();
        NecromancerStats necroHP = collision.GetComponent<NecromancerStats>();
        StatsLvl3 lvl3 = collision.GetComponent<StatsLvl3>();
        BossStats boss = collision.GetComponent<BossStats>();

        if (enemieHP != null)
        {
            enemieHP.DamageAttack(_damage);
            Destroy(this.gameObject);
        }
        else if (necroHP != null)
        {
            necroHP.DamageAttack(_damage);
            Destroy(this.gameObject);
        }
        else if (lvl3 != null)
        {
            lvl3.DamageAttack(_damage);
            Destroy(this.gameObject);
        }
        else if (boss != null)
        {
            boss.DamageAttack(_damage);
            Destroy(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }

    }

   


}
