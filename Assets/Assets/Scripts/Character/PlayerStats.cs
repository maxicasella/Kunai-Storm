using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int timeToDestroy;
    public float playerHp;
    public float baseHp = 100;
    public float playerMana;
    public float baseMana = 100;
    public bool lvlKey; /*Llaves obtenidas*/

    public Animator playerAnim;
    public UIhp canvasHP;
    //public ParticleSystem _blood;
   
   private void Awake()
    {
        playerHp = baseHp;
        playerMana = baseMana;
        lvlKey = false;
        
    }

    private void Start()
    {
        canvasHP.HPui(playerHp);
        
    }

    public void Damage (float damage) /*Recibir daño*/
    {
        if (damage>0 && playerHp >0)
        {
            playerHp -= damage;
            //Instantiate(_blood, transform.position, Quaternion.identity);
            canvasHP.UpdateHP(playerHp);
            
        }

    }

    public void PotionHp(float hp) /*Pocion Vida*/
    {
        if(playerHp<100)
        {
          playerHp += hp;
          canvasHP.UpdateHP(playerHp);
        }        
    }
    
    public void Key()
    {
        lvlKey = true;
    }

}
