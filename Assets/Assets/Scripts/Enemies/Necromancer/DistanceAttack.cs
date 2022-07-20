using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAttack : MonoBehaviour
{
    
    [SerializeField] Transform _target;
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
     

        if (_playerDetected)
        {
            if(Time.time > _timeToShoot)
            {
                _timeToShoot = Time.time + 1 / _fireRange;
               
            }
            
        }
    }

    //public void Fireball()
    //{
    //    Instantiate(_fireball, _shootPoint.position, Quaternion.identity);
    //    fireballRb = GetComponent<Rigidbody2D>();
    //    fireballRb.AddForce(_rayDir * _force);
    //}
}
