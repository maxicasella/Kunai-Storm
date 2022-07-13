using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public bool kunaiEquip;
    public bool katanaEquip;
    private int _weapon;
    public float playerMana;
    public float baseMana = 100;
    private float _powerKunai = 5;
    private float _powerKatana = 5;
    public bool _katanaRecolectable;
    public float kunaiNormDamage;
    public float katanaNormDamage;
    public float katanaPowerDamage;
    public float timeshoot;
    float timeToShoot;

    Animator playerMovement;
    public Transform ShootControler;
    public GameObject kunai;
    public Weapons equipment;
    public UImana canvasMana;

     

    private void Awake()
    {
        _katanaRecolectable = false;
        playerMana = baseMana;
    }

    void Start()
    {
        katanaEquip = false;
        PlayerStats PlayerStats = GetComponent<PlayerStats>();
        playerMovement = GetComponent<Animator>();
        canvasMana.ManaUI(playerMana);
        equipment.UpdateEquipment(katanaEquip, kunaiEquip);
    }

    void Update()
    {

        //Cambio de arma
        if (Input.GetButton("Jump"))
        {
            kunaiEquip = true;
            playerMovement.SetBool("Kunai", true);
            katanaEquip = false;
            playerMovement.SetBool("Katana", false);

        }
        if (Input.GetButton("Submit") && _katanaRecolectable)
        {
            kunaiEquip = false;
            playerMovement.SetBool("Kunai", false);
            katanaEquip = true;
            playerMovement.SetBool("Katana", true);

        }

        if (katanaEquip == true && kunaiEquip == false)
        {
            equipment.UpdateEquipment(katanaEquip, kunaiEquip);
        }
        if (katanaEquip == false && kunaiEquip == true)
        {
            equipment.UpdateEquipment(katanaEquip, kunaiEquip);
        }


        //Ataques click derecho
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (kunaiEquip)
            {
                playerMovement.SetBool("AttackNormKunai", true);

            }
            else if (katanaEquip)
            {
                playerMovement.SetBool("AttackNormKatana", true);
            }


        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (kunaiEquip)
            {
                playerMovement.SetBool("AttackNormKunai", false);
            }
            else if (katanaEquip)
            {
                playerMovement.SetBool("AttackNormKatana", false);
            }
        }


        //Ataques click izquierdo
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (kunaiEquip && Time.time > timeToShoot && playerMana > 0)
            {
                playerMovement.SetBool("AttackPowerKunai", true);
                timeToShoot = Time.deltaTime + timeshoot;
                playerMana -= _powerKunai;
                Kunai();
                canvasMana.UpdateMana(playerMana);

            }
            else
            {
                playerMovement.SetBool("AttackPowerKunai", false);
            }

            if (katanaEquip && playerMana > 0)
            {
                playerMovement.SetBool("AttackPowerKatana", true);
                playerMana -= _powerKatana;
                canvasMana.UpdateMana(playerMana);

            }
            else
            {
                playerMovement.SetBool("AttackPowerKatana", false);
            }


        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (kunaiEquip)
            {
                playerMovement.SetBool("AttackPowerKunai", false);
            }
            else if (katanaEquip)
            {
                playerMovement.SetBool("AttackPowerKatana", false);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) /*Hacer daño*/
    {
        EnemieStats enemieHP = collision.GetComponent<EnemieStats>();
        NecromancerStats necroHP = collision.GetComponent<NecromancerStats>();

        if (enemieHP != null && kunaiEquip)
        {
            enemieHP.DamageAttack(kunaiNormDamage);

        }

        if (enemieHP != null && katanaEquip)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                enemieHP.DamageAttack(katanaNormDamage);
            }
            else
            {
                enemieHP.DamageAttack(katanaPowerDamage);
            }
        }

        if(necroHP != null && kunaiEquip)
        {
            necroHP.DamageAttack(kunaiNormDamage);

        }

        if (necroHP != null && katanaEquip)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                necroHP.DamageAttack(katanaNormDamage);
            }
            else
            {
                necroHP.DamageAttack(katanaPowerDamage);
            }
        }

    }

   
    public void Kunai() /*Instanciar Kunai*/
    {
        Instantiate(kunai, transform.position, Quaternion.identity);        
    }

    public void PotionMana(float mana)
    {
        if (playerMana < 100)
        {
            playerMana += mana;
            canvasMana.UpdateMana(playerMana);
        }
    }

    public void Katana(bool equip)
    {
        if (_katanaRecolectable == false)
        {
            _katanaRecolectable = equip;
        }
    }
}
