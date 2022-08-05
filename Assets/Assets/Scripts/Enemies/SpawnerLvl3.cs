using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLvl3 : MonoBehaviour
{
    [SerializeField] KillCounter _kills;
    [SerializeField] GameObject _enemieSword;
    [SerializeField] GameObject _enemieSpear;
    [SerializeField] Transform _spawnA;
    [SerializeField] Transform _spawnB;
    [SerializeField] GameObject _particulas;
    [SerializeField] AudioSource _audio;

    public float spawn = 1;

    private void Awake()
    {
        _audio.Play();
        Instantiate(_particulas, _spawnB.position, Quaternion.identity);
        Instantiate(_particulas, _spawnA.position, Quaternion.identity);
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
                    _audio.Play();
                    Instantiate(_particulas, _spawnB.position, Quaternion.identity);
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 2:
                    _audio.Play();
                    Instantiate(_particulas, _spawnA.position, Quaternion.identity);
                    Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 3:
                    _audio.Play();
                    Instantiate(_particulas, _spawnA.position, Quaternion.identity);
                    Instantiate(_particulas, _spawnB.position, Quaternion.identity);
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 4:
                    _audio.Play();
                    Instantiate(_particulas, _spawnA.position, Quaternion.identity);
                    Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 5:
                    _audio.Play();
                    Instantiate(_particulas, _spawnB.position, Quaternion.identity);
                    Instantiate(_enemieSword, _spawnB.position, Quaternion.identity);
                    spawn = 0;
                    break;
                case 6:
                    _audio.Play();
                    Instantiate(_particulas, _spawnA.position, Quaternion.identity);
                    Instantiate(_enemieSpear, _spawnA.position, Quaternion.identity);
                    spawn = 0;
                    break;

            }

        }

    }
}


