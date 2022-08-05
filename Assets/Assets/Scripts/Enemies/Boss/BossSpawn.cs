using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    [SerializeField] BossStats _bossHp;
    [SerializeField] GameObject _soldiersA;
    [SerializeField] Transform _spawnerA;
    [SerializeField] GameObject _soldierB;
    [SerializeField] Transform _spawnerB;
    [SerializeField] Animator _myAnim;
    [SerializeField] float _spawn;
    [SerializeField] GameObject _darkAura;
    [SerializeField] Transform _particlesPoint;
    


    private void Update()
    {
        if (_bossHp.bossHP <= 200)
        {
            _spawn = 1;

            switch(_spawn)
            {
                case 1:
                    _myAnim.SetTrigger("Invocacion");
                    Instantiate(_darkAura, _particlesPoint.position, Quaternion.identity);
                    Instantiate(_soldiersA, _spawnerA.position, Quaternion.identity);
                    Instantiate(_soldierB, _spawnerB.position, Quaternion.identity);
                    _spawn = 0;
                    Destroy(this);
                     break;
                    
            }

          
            
        }
    }

    

   
}
