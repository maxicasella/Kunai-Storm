using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject _trigger;
    [SerializeField] GameObject _humo;
    [SerializeField] GameObject _bloqueoCamino;
    [SerializeField] GameObject _uiBoss;
    [SerializeField] Animator _visionAnim;
    [SerializeField] GameObject _boss;
    [SerializeField] GameObject _particulas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _humo.SetActive(true);
        Instantiate(_particulas, transform.position, Quaternion.identity);
        _uiBoss.SetActive(true);
        _boss.SetActive(true);
        _visionAnim.SetTrigger("Destroy");

        Destroy(_humo,0.3f);
        Destroy(_bloqueoCamino);
        Destroy(_trigger);
    }


}
