using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraShield : MonoBehaviour
{
    [SerializeField] float _shiedlHP;
    [SerializeField] AudioSource _audioLoop;
    [SerializeField] AudioSource _audioBreak;
    [SerializeField] GameObject _particulas;
    [SerializeField] AudioSource _golpe;
    [SerializeField] GameObject _golpeParticula;

    private void Update()
    {
       
    }

    public void DamageAttack(float damage)
    {
        if (damage > 0 && _shiedlHP >= 0) /*Recibir daño*/
        {
            _shiedlHP -= damage;
            _golpe.Play();
            Instantiate(_golpeParticula, transform.position, Quaternion.identity);

        }

        if (_shiedlHP <= 0)
        {
            _audioLoop.Stop();
            _audioBreak.Play();
            Instantiate(_particulas, transform.position, Quaternion.identity);
            Destroy(this.gameObject,1.4f);
        }
    }

  
}
