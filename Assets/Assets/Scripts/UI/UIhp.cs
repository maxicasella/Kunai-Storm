using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIhp : MonoBehaviour
{
    Slider sliderHp;
    
    void Start()
    {
        sliderHp = GetComponent<Slider>();
    }

    public void MaxHP(float baseHP)
    {
        sliderHp.maxValue = baseHP;
    }

    public void UpdateHP(float playerHP)
    {
        sliderHp.value = playerHP;
    }

    public void HPui (float hp)
    {
        MaxHP(hp);
        UpdateHP(hp);
    }
}
