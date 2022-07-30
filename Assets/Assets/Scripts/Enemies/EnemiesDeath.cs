using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeath : MonoBehaviour
{
    [SerializeField] KillCounter killsCounter;
    [SerializeField] float goFinal;
    [SerializeField] Animator myAnim;
    [SerializeField] GameObject _final;

    private void Update()
    {
        if (killsCounter.killsCounter == goFinal)
        {
            myAnim.SetTrigger("Break");
            _final.SetActive(true);
            Destroy(this.gameObject, 1);
        }   
    }


}
