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


        if (enemieHP != null && player.kunaiEquip)
        {
            enemieHP.DamageAttack(player.kunaiNormDamage);
         
        }

       
        if (necroHP != null && player.kunaiEquip)
        {
            necroHP.DamageAttack(player.kunaiNormDamage);

        }

        

    }
}
