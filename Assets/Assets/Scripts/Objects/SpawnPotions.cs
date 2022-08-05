using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotions : MonoBehaviour
{
    [SerializeField] PlayerStats _stats;
    [SerializeField] Transform _spawnMana;
    [SerializeField] Transform _spawnHp;
    [SerializeField] GameObject _hpPotion;
    [SerializeField] GameObject _manaPotion;

    [SerializeField] float _spawns = 2;

    private void Update()
    {
        if(_stats.playerHp < 100 && _spawns == 2)
        {
            Instantiate(_hpPotion, _spawnHp.position, Quaternion.identity);
            _spawns--;
        }

        if (_stats.playerMana < 50 && _spawns == 1)
        {
            Instantiate(_manaPotion, _spawnMana.position, Quaternion.identity);
            _spawns--;
        }
    }

}
