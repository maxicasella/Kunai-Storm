using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PjAttack : MonoBehaviour
{

    [SerializeField] int _weapon;
    [SerializeField] GameObject _kunai;
    [SerializeField] PlayerStats _pjStats;
    [SerializeField] Weapons _weaponUI;
    [SerializeField] Animator playerMovement;
    [SerializeField] UImana _canvasMana;
    [SerializeField] float _timeShoot;

    public bool _hasKatana; /*Cambiar despues a privado*/

    public bool katanaEquip;
    public bool kunaiEquip;
    public float katanaSpDmg;
    public float katanaDmg;
    public float kunaiSpDmg;
    public float kunaiDmg;
    public float attackCoast;

    public void Start()
    {
        _hasKatana = false;
        katanaEquip = false;
        kunaiEquip = true;
        _weaponUI.UpdateEquipment(katanaEquip, kunaiEquip);
    }

    public void Update()
    {
        //Cambio de arma
        if (Input.GetButton("Jump"))
        {
            kunaiEquip = true;
            playerMovement.SetBool("Kunai", true);
            katanaEquip = false;
            playerMovement.SetBool("Katana", false);

        }
        if (Input.GetButton("Submit") && _hasKatana)
        {
            kunaiEquip = false;
            playerMovement.SetBool("Kunai", false);
            katanaEquip = true;
            playerMovement.SetBool("Katana", true);

        }

        //Actualizacion Weapon UI
        if (katanaEquip == true && kunaiEquip == false)
        {
            _weaponUI.UpdateEquipment(katanaEquip, kunaiEquip);
        }
        if (katanaEquip == false && kunaiEquip == true)
        {
            _weaponUI.UpdateEquipment(katanaEquip, kunaiEquip);
        }


        //Ataques click derecho
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (kunaiEquip)
            {
                playerMovement.SetBool("AttackNormKunai", true);
                _pjStats.Damage(kunaiDmg);
            }
            else if (katanaEquip)
            {
                playerMovement.SetBool("AttackNormKatana", true);
                _pjStats.Damage(katanaDmg);
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
            if (kunaiEquip && Time.time > _timeShoot && _pjStats.playerMana > 0)
            {
                playerMovement.SetBool("AttackPowerKunai", true);
                _timeShoot = Time.deltaTime + _timeShoot;
                _pjStats.playerMana -= attackCoast;
                _pjStats.Damage(kunaiSpDmg);
                Kunai();
                _canvasMana.ManaUI(_pjStats.playerMana);

            }
            else
            {
                playerMovement.SetBool("AttackPowerKunai", false);
            }

            if (katanaEquip && _pjStats.playerMana > 0)
            {
                playerMovement.SetBool("AttackPowerKatana", true);
                _pjStats.playerMana -= attackCoast;
                _pjStats.Damage(katanaSpDmg);
                _canvasMana.ManaUI(_pjStats.playerMana);

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


    public void Katana(bool equip) /*Obtener Katana*/
    {
        if (_hasKatana == false)
        {
            _hasKatana = equip;
        }

    }

    public void Kunai() /*Instanciar Kunai - REVISAR*/
    {
        Instantiate(_kunai, transform.position, Quaternion.identity);
    }
}

