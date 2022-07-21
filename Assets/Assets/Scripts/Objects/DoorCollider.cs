using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCollider : MonoBehaviour
{
    public GameObject doorCanvas;

    public PlayerStats keyReference;

    private void OnTriggerStay2D(Collider2D collision)
    {

        doorCanvas.SetActive(true);
        keyReference.Golevel();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        doorCanvas.SetActive(false);
    }
}
