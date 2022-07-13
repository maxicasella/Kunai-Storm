using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HasKey : MonoBehaviour
{
    public Text key;

    public PlayerStats stats;

    private void Awake()
    {
        key.text = "x 0";
    }

    private void Update()
    {
        if (stats.lvlKey)
        {
            key.text = "x 1";
        }
    }

   
}
