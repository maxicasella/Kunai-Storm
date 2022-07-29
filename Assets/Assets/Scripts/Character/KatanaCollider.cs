using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaCollider : MonoBehaviour
{
    public PlayerAttack player;

    private void OnTriggerEnter2D(Collider2D collision) /*Hacer daño*/
    {
        EnemieStats enemieHP = collision.GetComponent<EnemieStats>();
        NecromancerStats necroHP = collision.GetComponent<NecromancerStats>();
        StatsLvl3 lvl3 = collision.GetComponent<StatsLvl3>();

        if (enemieHP != null && player.katanaEquip)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                enemieHP.DamageAttack(player.katanaNormDamage);
            }
            else
            {
                enemieHP.DamageAttack(player.katanaPowerDamage);
            }
        }

        if (necroHP != null && player.katanaEquip)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                necroHP.DamageAttack(player.katanaNormDamage);
            }
            else
            {
                necroHP.DamageAttack(player.katanaPowerDamage);
            }
        }

        if (lvl3 != null && player.katanaEquip)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                lvl3.DamageAttack(player.katanaNormDamage);
            }
            else
            {
                lvl3.DamageAttack(player.katanaPowerDamage);
            }
        }
    }
}

