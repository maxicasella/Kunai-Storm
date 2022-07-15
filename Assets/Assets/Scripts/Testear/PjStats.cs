using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PjStats: MonoBehaviour
{
    [SerializeField] float _actualLife;
    [SerializeField] float _baseMana;
    [SerializeField] UIhp _canvasHP;
    [SerializeField] UImana _canvasMana;
    [SerializeField] ParticleSystem _blood;

   public  bool _hasKey; /*Cambiar despues a privado*/

    public float _baseLife;
    public float _actualMana;
    public float actualDamage;

    public void Awake ()
    {
        _actualLife = _baseLife;
        _actualMana = _baseMana;
        _hasKey = false;
    }

    public void Start ()
    {

        //Actualizar UIs
        _canvasHP.HPui(_actualLife);

        _canvasMana.ManaUI(_actualMana);

    }


    public void DamageAttack(float dmg)/* Al realizar cada ataque le actualizo el valor */
    {
        actualDamage = dmg;
    }
    
    public void ReceiveDamage(float damage) /*Recibir daño*/
    {
        if (damage > 0 && _actualLife > 0)
        {
            _actualLife -= damage;
            Instantiate(_blood, transform.position, Quaternion.identity);
           _canvasHP.UpdateHP(_actualLife);

        }

    }

    public void PotionHp(float hp) /*Pocion Vida*/
    {
        if (_actualLife < _baseLife)
        {
            _actualLife += hp;
           _canvasHP.UpdateHP(_actualLife);
        }
    }


    public void PotionMana(float mana) /*Pocion Mana*/
    {
        if (_actualMana < _baseMana)
        {
           _actualMana += mana;
            _canvasMana.UpdateMana(_actualMana);
        }
    }

    public void Key() /*Obtener llave para pasar de escenario*/
    {
        _hasKey = true;
    }

}
