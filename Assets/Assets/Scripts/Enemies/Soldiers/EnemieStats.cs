using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieStats : MonoBehaviour
{
    public float enemieHP;
    public float baseHP;
    public float enemieDamage;
    public float timeToDestroy;
    Animator enemieAnim;
    public GameObject mana;
    public GameObject hp;
    [SerializeField] EnemiesDeath[] kills;
    [SerializeField] SpawnerLvl3 _spawn;
    [SerializeField] GameObject _impactParticle;
    [SerializeField] AudioSource _audio;

    private void Awake()
    {
        enemieHP = baseHP;
    }

    void Start()
    {
        enemieAnim = GetComponent<Animator>();
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
        

        if (damage > 0 && enemieHP >= 0) /*Recibir daño*/
        {
            enemieHP -= damage;
            _audio.Play();
            Instantiate(_impactParticle, transform.position, Quaternion.identity);
            
        }

        if (enemieHP <= 0)
        {
            int potions = Random.Range(0, 9);
            switch (potions)
            {
                case 1:
                    Instantiate(mana, transform.position, transform.rotation);
                    break;
                case 6: Instantiate(hp, transform.position, transform.rotation);
                    break;
            }
            enemieAnim.SetTrigger("Death");
                       
        
            Destroy(this.gameObject,0.2f);
                
        }
    }

}
