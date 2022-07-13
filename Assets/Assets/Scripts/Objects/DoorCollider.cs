using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCollider : MonoBehaviour
{
    public GameObject doorCanvas;

    private void OnTriggerStay2D(Collider2D collision)
    {

        doorCanvas.SetActive(true);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        doorCanvas.SetActive(false);
    }
}
