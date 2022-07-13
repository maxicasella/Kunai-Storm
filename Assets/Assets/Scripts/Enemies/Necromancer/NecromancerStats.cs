using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerStats : MonoBehaviour
{
    public float necroHP;
    public float baseHP;
    public float necroDamage;
    public float timeToDestroy;
    Animator enemieAnim;
    public GameObject key;
    
    private void Awake()
    {
        necroHP = baseHP;
    }

    void Start()
    {
        enemieAnim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision) /*Hacer daño al pj*/
    {
        PlayerStats playerHp = collision.collider.GetComponent<PlayerStats>();

        if (playerHp != null)
        {
            playerHp.Damage(necroDamage);
        }
    }

    public void DamageAttack(float damage)
    {
        if (damage > 0 && necroHP >= 0) /*Recibir daño*/
        {
            necroHP -= damage;
        }

        if (necroHP <= 0)
        {
            Instantiate(key, transform.position, transform.rotation);
            enemieAnim.SetTrigger("Death");
            Destroy(this.gameObject, 0.2f);

        }
    }
   
}
