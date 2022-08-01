using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    Animator _myAnim;

    private void Start()
    {
        _myAnim = GetComponent<Animator>();
    }
    public void ChangeState()
    {
        _myAnim.SetBool("Iddle", true);
    }
}
