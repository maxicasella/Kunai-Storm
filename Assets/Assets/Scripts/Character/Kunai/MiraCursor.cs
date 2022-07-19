using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraCursor : MonoBehaviour
{
    public Transform cursor;
    public Transform shootPoint;

    public void Update()
    {
        //Mira/Cursor

        //cursor.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));

        //Rotacion shootpoint

        Vector3 rotation = cursor.position - shootPoint.position;
        float z = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        shootPoint.rotation = Quaternion.Euler(0, 0, z);

    }
}
