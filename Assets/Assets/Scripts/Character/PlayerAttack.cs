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
    public float timeToShoot;

    Animator playerMovement;
    public Transform ShootControler;
    public GameObject kunai;
    public Weapons equipment;
    public UImana canvasMana;

    [SerializeField] SpriteRenderer _shootPoint;
    [SerializeField] AudioSource _katanaNorm;
    [SerializeField] AudioSource _katanaPwr;
    [SerializeField] AudioSource _kunaiNorm;
    [SerializeField] AudioSource _kunaiPwr;

    private void Awake()
    {
        //_katanaRecolectable = false;
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
        if (timeToShoot >=  0)
        {
            timeToShoot = timeToShoot - Time.time;
        }
        else if (timeToShoot <= 0)
        {
            timeToShoot = timeshoot;
        }

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
            if (kunaiEquip && timeToShoot >=1 && playerMana > 0)
            {
                playerMovement.SetBool("AttackPowerKunai", true);
                //timeToShoot = Time.deltaTime + timeshoot;
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

   

   
    public void Kunai() /*Instanciar Kunai*/
    {

        
        if (_shootPoint.flipX)
        {
            Instantiate(kunai, transform.position, Quaternion.Euler(0,0,-180));
        }
        else
        {
            Instantiate(kunai, transform.position, Quaternion.Euler(0, 0, 0));
        }

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

    public void AudioKatanaNorm()
    {
        _katanaNorm.Play();
    }

    public void AudioKunaiNorm()
    {
        _kunaiNorm.Play();
    }

    public void AudioKunaiPwr()
    {
        _kunaiPwr.Play();
    }

    public void AudioKatanaPwr()
    {
        _katanaPwr.Play();
    }
}
