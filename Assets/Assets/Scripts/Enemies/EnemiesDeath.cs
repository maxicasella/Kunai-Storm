using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeath : MonoBehaviour
{
    public float killsCounter;
    [SerializeField] float goFinal;
    [SerializeField] Animator myAnim;

    private void Update()
    {
        if (killsCounter == goFinal)
        {
            myAnim.SetTrigger("Break");
            Destroy(this.gameObject, 1);
        }   
    }


}
