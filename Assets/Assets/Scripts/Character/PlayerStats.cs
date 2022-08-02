using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public PlayerAttack weapon;
    public GameObject blood;

    public string scene;
   
   private void Awake()
    {
        playerHp = baseHp;
        playerMana = baseMana;
        lvlKey = false;
        
    }

    private void Start()
    {
        //canvasHP.HPui(playerHp);
        
    }

    public void Damage (float damage) /*Recibir daño*/
    {
        if (damage>0 && playerHp >0)
        {
            playerHp -= damage;
            Instantiate(blood, transform.position, Quaternion.identity);
            canvasHP.UpdateHP(playerHp);
            
        }

        if (playerHp <= 0)//Animacion de muerte
        {

            if (weapon.kunaiEquip == true)
            {
                playerAnim.SetTrigger("Death Kunai");
               
            }
            else if (weapon.katanaEquip == true)
            {
                playerAnim.SetTrigger("Death Katana");
                
            }


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
    public void Golevel()
    {
        if (Input.GetKeyDown(KeyCode.E) && lvlKey == true)
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(9);
    }
}
