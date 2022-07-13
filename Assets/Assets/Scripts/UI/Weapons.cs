using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{

    public GameObject kunaiYes;
    public GameObject kunaiNo;
    public GameObject katanaYes;
    public GameObject KatanaNo;

    public void Kunai(bool kunaiEquip)
    {
        if (kunaiEquip)
        {
            kunaiYes.SetActive(true);
            kunaiNo.SetActive(false);
                       
        }
        else
        {
            kunaiNo.SetActive(true);
            kunaiYes.SetActive(false);
        }
    }

    public void Katana (bool katanaEquip)
    {
        if (katanaEquip)
        {
            katanaYes.SetActive(true);
            KatanaNo.SetActive(false);
        }
        else
        {
            KatanaNo.SetActive(true);
            katanaYes.SetActive(false);
        }
    }

    public void UpdateEquipment (bool katanaEquip, bool kunaiEquip)
    {
        Katana(katanaEquip);
        Kunai (kunaiEquip);
    }

}
