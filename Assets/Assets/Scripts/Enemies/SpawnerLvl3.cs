﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLvl3 : MonoBehaviour
{
    [SerializeField] KillCounter _kills;
    [SerializeField] GameObject _enemieSword;
    [SerializeField] GameObject _enemieSpear;
    [SerializeField] Transform _spawnA;
    [SerializeField] Transform _spawnB;

    public float spawn = 1;

    private void Awake()
    {
        Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
        Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
    }
    private void Update()
    {
        if (spawn == 1)
        {
            switch (_kills.killsCounter)
            {
                case 1:
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 2:
                     Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 3:
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 4:
                    Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 5:
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 6:
                    Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;

            }

        }

    }
}


