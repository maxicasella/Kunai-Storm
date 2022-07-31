using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunai : MonoBehaviour
{
    public PlayerAttack player;


    private void OnTriggerEnter2D(Collider2D collision) /*Hacer daño*/
    {
        EnemieStats enemieHP = collision.GetComponent<EnemieStats>();
        NecromancerStats necroHP = collision.GetComponent<NecromancerStats>();
        StatsLvl3 lvl3 = collision.GetComponent<StatsLvl3>();
        BossStats boss = collision.GetComponent<BossStats>();

        if (enemieHP != null && player.kunaiEquip)
        {
            enemieHP.DamageAttack(player.kunaiNormDamage);
         
        }

       
        if (necroHP != null && player.kunaiEquip)
        {
            necroHP.DamageAttack(player.kunaiNormDamage);

        }

        if (lvl3 != null && player.kunaiEquip)
        {
            lvl3.DamageAttack(player.kunaiNormDamage);
        }

        if (boss != null && player.kunaiEquip)
        {
            boss.DamageAttack(player.kunaiNormDamage);
        }
    }
}
