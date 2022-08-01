using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossColliderAttack : MonoBehaviour
{
    public BossStats stats;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats playerHp = collision.GetComponent<PlayerStats>();

        if (playerHp != null)
        {

            playerHp.Damage(stats.enemieDamage);
        }
    }
}
