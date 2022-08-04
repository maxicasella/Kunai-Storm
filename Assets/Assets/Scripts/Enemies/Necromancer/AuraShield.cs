using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraShield : MonoBehaviour
{
    [SerializeField] float _shiedlHP;
    [SerializeField] AudioSource _audioLoop;
    [SerializeField] AudioSource _audioBreak;
    [SerializeField] GameObject _particulas;

    private void Update()
    {
        if (_shiedlHP <= 0)
        {
            _audioLoop.Stop();
            _audioBreak.Play();
            Instantiate(_particulas, transform.position, Quaternion.identity);
        }
    }
}
