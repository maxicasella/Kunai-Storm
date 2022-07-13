using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiVel : MonoBehaviour
{
    public float velocityx;
    public float velocityy = 0;
    public float timeTodestroy;
    public float kunaiPowerDamage;

    
    Rigidbody2D kunaiRb;

    void Start()
    {
        kunaiRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        kunaiRb.velocity = new Vector2(+velocityx, +velocityy);
        Destroy(this.gameObject, timeTodestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemieStats enemieHP = collision.GetComponent<EnemieStats>();
        NecromancerStats necroHP = collision.GetComponent<NecromancerStats>();
        if (enemieHP !=null)
        {
            enemieHP.DamageAttack(kunaiPowerDamage);
            Destroy(this.gameObject);
        }
        else if (necroHP != null)
        {
            necroHP.DamageAttack(kunaiPowerDamage);
            Destroy(this.gameObject);
        }
    }

}
