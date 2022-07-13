using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerVision : MonoBehaviour
{
    public Animator enemies;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        enemies.SetBool("Attack", true);
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemies.SetBool("Attack", false);
      
    }
}
