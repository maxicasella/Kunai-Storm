using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeath : MonoBehaviour
{
    [SerializeField] KillCounter killsCounter;
    [SerializeField] float goFinal;
    [SerializeField] Animator myAnim;
    [SerializeField] GameObject _final;
    [SerializeField] AudioSource _audio;
    [SerializeField] GameObject _particulas;

    private void Update()
    {
        if (killsCounter.killsCounter >= goFinal)
        {
            myAnim.SetTrigger("Break");
            Instantiate(_particulas, transform.position, Quaternion.identity);
            Destroy(this.gameObject, 1.5f);
        }   
    }

    public void Audio()
    {
        _audio.Play();
    }

    public void FinalLevel()
    {
        _final.SetActive(true);
    }

}
