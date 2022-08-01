using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Transform _playerT;
    [SerializeField] Transform _iddleT;
    public Transform targetPoint;
    [SerializeField] SpriteRenderer _mySpriteR;
    [SerializeField] VisionRange _move;
    [SerializeField] Animator _myAnim;

    private void Start()
    {
        targetPoint = _iddleT;

       
    }

    private void Update()
    {
        if (targetPoint == _playerT)
        {
            _move.isMove = true;
            _myAnim.SetBool("Caminata", true);
        }
    }

    private void FixedUpdate()
    {

        if (_move.isMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, _speed * Time.deltaTime);

        }

    }

}

