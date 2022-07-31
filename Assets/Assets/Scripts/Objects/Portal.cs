using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject _trigger;
    [SerializeField] GameObject _humo;
    [SerializeField] GameObject _bloqueoCamino;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _humo.SetActive(true);
        Destroy(_trigger);
        Destroy(_bloqueoCamino);
    }


}
