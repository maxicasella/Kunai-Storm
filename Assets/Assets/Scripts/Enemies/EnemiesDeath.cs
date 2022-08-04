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

    private void Update()
    {
        if (killsCounter.killsCounter >= goFinal)
        {
            myAnim.SetTrigger("Break");
            Destroy(this.gameObject, 1f);
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
