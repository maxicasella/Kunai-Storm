﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossStats : MonoBehaviour
{
    public float bossHP;
    public float baseHP;
    public float enemieDamage;
    Animator enemieAnim;
    public BossUI ui;
    [SerializeField] GameObject _uiBoss;
    [SerializeField] GameObject _particleSystem;
    [SerializeField] AudioSource _audio;

    private void Awake()
    {

        enemieAnim = GetComponent<Animator>();
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
            Instantiate(_particleSystem, transform.position, Quaternion.identity);
            ui.UpdateHP(bossHP);
        }

        if (bossHP <= 0)
        {
            enemieAnim.SetTrigger("Death");
            Destroy(this.gameObject, 1.5f);
            Destroy(_uiBoss);
            

        }
    }

    public void PlayerWin()
    {
        SceneManager.LoadScene(10);
    }

    public void AudioDeath()
    {
        _audio.Play();
    }
}



