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
    }
}

