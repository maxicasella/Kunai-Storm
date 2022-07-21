using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform enemie;

    private void FixedUpdate()
    {

        var pos = transform.position;
        pos = enemie.position;
    }
}
