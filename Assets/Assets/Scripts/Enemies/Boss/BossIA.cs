using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIA : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator _bossAnimator;
    public Transform point1;
    public Transform point2;
    public Transform targetPoint;
    [SerializeField] SpriteRenderer spriteRenderer;

    public VisionRange move;

    private void FixedUpdate()
    {


        if (move.isMove)
        {

            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPoint.position) == 0.00)
            {

                if (targetPoint == point1)
                {

                    targetPoint = point2;
                    spriteRenderer.flipX = true;
                }
                else if (targetPoint == point2)
                {

                    targetPoint = point1;
                    spriteRenderer.flipX = false;
                }
            }
        }
    }
}

