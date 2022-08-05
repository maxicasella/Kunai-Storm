using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsLvl3 : MonoBehaviour
{
    public float enemieHP;
    public float baseHP;
    public float enemieDamage;
    public float timeToDestroy;
    Animator enemieAnim;
    public GameObject mana;
    public GameObject hp;
    //[SerializeField] EnemiesDeath[] kills;
    [SerializeField] SpawnerLvl3 _spawn;
    [SerializeField] KillCounter _kills;
    [SerializeField] GameObject _impactParticle;
    [SerializeField] AudioSource _audio;
    [SerializeField] GameObject _particula;

    private void Awake()
    {
        enemieHP = baseHP;
        _kills = GameObject.FindGameObjectWithTag("Player").GetComponent<KillCounter>();
        _spawn = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnerLvl3>();
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
            Instantiate(_impactParticle, transform.position, Quaternion.identity);
        }

        if (enemieHP <= 0)
        {
            int potions = Random.Range(0, 8);
            switch (potions)
            {
                case 1:
                    Instantiate(mana, transform.position, transform.rotation);
                    break;
                case 3:
                    Instantiate(mana, transform.position, transform.rotation);
                    break;
                case 5:
                    Instantiate(hp, transform.position, transform.rotation);
                    break;
                case 7:
                    Instantiate(hp, transform.position, transform.rotation);
                    break;
            }
            enemieAnim.SetTrigger("Death");
            //for (int i = 0; i < kills.Length; i++)
            //{
            //    kills[i].killsCounter = kills[i].killsCounter + 1;

            //}
            _kills.killsCounter = _kills.killsCounter + 1;

            if (_spawn.spawn == 0)
            {
                _spawn.spawn = 1;
            }


            Destroy(this.gameObject, 0.2f);

        }

    }

    public void EnemieAudio()
    {
        _audio.Play();
    }

    public void ParticulaMuerte()
    {
        Instantiate(_particula, transform.position, Quaternion.identity);
    }
}

