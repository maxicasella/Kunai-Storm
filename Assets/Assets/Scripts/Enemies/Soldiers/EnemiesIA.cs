using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesIA : MonoBehaviour
{
    public float speed;
    Animator enemiesAnimator;
    public Transform point1;
    public Transform point2;
    public Transform targetPoint;
    SpriteRenderer spriteRenderer;
    
    
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemiesAnimator = GetComponent<Animator>();
        targetPoint = point1;
        

        if (targetPoint=point1)
        {
            enemiesAnimator.SetBool("Caminata", true);
        }
    }

    private void FixedUpdate()
    {
           
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) == 0.00)
        {
            
            if (targetPoint == point1)
            {
                targetPoint = point2;
                spriteRenderer.flipX = true;
            }
            else if (targetPoint==point2)
            {
                targetPoint = point1;
                spriteRenderer.flipX = false;
            }
        }
       
        
       
    }

    



}
    


  
