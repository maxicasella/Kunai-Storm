using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImana : MonoBehaviour
{
    Slider sliderMana;

    void Start()
    {
        sliderMana = GetComponent<Slider>();
    }

    public void MaxMana (float baseMana)
    {
        sliderMana.maxValue = baseMana;
    }

    public void UpdateMana (float playerMana)
    {
        sliderMana.value = playerMana;
    }

    public void ManaUI (float playerMana)
    {
        MaxMana(playerMana);
        UpdateMana(playerMana);
    }
}
