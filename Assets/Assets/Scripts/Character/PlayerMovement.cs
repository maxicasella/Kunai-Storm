using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRgbd;
    public float movementSpeed;
    public Animator playerMovement;
    

    void FixedUpdate()
    {
        Vector2 inputMovement;
        inputMovement.x = Input.GetAxis("Horizontal");
        inputMovement.y = Input.GetAxis("Vertical");
        playerMovement.SetFloat("HorizontalMov", inputMovement.x);
        playerMovement.SetFloat("VerticalMov", inputMovement.y);

        if (inputMovement.x != 0 || inputMovement.y != 0)
        {
            playerRgbd.MovePosition(playerRgbd.position + inputMovement * movementSpeed * Time.deltaTime);
            playerMovement.SetBool("Movement", true);
        }
        else
        {
            playerMovement.SetBool("Movement", false);
        }
    }

}

