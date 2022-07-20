using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerVision : MonoBehaviour
{
    [SerializeField] Animator _enemies;
    [SerializeField] GameObject _fireball;
    [SerializeField] float _fireRange;
    [SerializeField] float _timeToShoot;
    [SerializeField] Transform _shootPoint;
    bool _playerDetected;


    private void Start()
    {
        _playerDetected = false;

    }

    private void Update()
    {
        
        if (_playerDetected)
        {
            if (Time.time > _timeToShoot)
            {
                _timeToShoot = Time.time + 1 / _fireRange;
                _enemies.SetBool("Attack", true);
               Instantiate(_fireball, _shootPoint.position, Quaternion.identity);
            }

        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        _enemies.SetBool("Iddle", false);
        
        if (_playerDetected == false)
        {
            _playerDetected = true;

        }
        else
        {
            if (_playerDetected == true)
            {
                _playerDetected = false;
            }

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _enemies.SetBool("Attack", false);
        _enemies.SetBool("Iddle", true);

        if (_playerDetected == true)
        {
            _playerDetected = false;
        }

    }




}



