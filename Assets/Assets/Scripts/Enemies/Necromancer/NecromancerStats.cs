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
    public UINecro ui;
    public GameObject particleSystem;
    public AudioSource audio;
    public GameObject muerteParticulas;

    [SerializeField] GameObject _ui;
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
            Instantiate(particleSystem, transform.position, Quaternion.identity);
            ui.UpdateHP(necroHP);
        }

        if (necroHP <= 0)
        {
            enemieAnim.SetTrigger("Death");
            Instantiate(muerteParticulas, transform.position, Quaternion.identity);
            Destroy(_ui.gameObject);
            Instantiate(key, transform.position, transform.rotation);
            Destroy(this.gameObject, 0.5f);

        }
    }

    public void AudioDeath()
    {
        audio.Play();
    }
   
}
