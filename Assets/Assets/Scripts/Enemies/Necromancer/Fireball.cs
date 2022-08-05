using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    [SerializeField] float _force;
    [SerializeField] Transform _target;
    [SerializeField] AudioSource _audio;
    [SerializeField] GameObject _particulas;
    
    public float dmg;
    
    Rigidbody2D _myRb;
    Vector2 _dir;

    private void Start()
    {
        _myRb = GetComponent<Rigidbody2D>();

        
        Vector2 targetPos = _target.position;
        _dir = targetPos - (Vector2)transform.position;
        _audio.Play();


    }
    private void FixedUpdate()
    {
        _myRb.AddForce(_dir * _force);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats pjStats = collision.GetComponent<PlayerStats>();

        if (pjStats != null)
        {
            pjStats.Damage(dmg);
            Instantiate(_particulas, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else
        {
            Instantiate(_particulas, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}
