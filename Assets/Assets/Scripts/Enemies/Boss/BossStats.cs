using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public float bossHP;
    public float baseHP;
    public float enemieDamage;
    public float timeToDestroy;
    Animator enemieAnim;
    public BossUI ui;

    private void Awake()
    {

        bossHP = baseHP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerStats playerHp = collision.collider.GetComponent<PlayerStats>();

        if (playerHp != null)
        {
            playerHp.Damage(enemieDamage);

        }
    }

    public void DamageAttack(float damage)
    {

        if (damage > 0 && bossHP >= 0) /*Recibir daño*/
        {
            bossHP -= damage;
            ui.UpdateHP(bossHP);
        }

        if (bossHP <= 0)
        {

            Destroy(this.gameObject, 0.2f);

        }
    }

}



