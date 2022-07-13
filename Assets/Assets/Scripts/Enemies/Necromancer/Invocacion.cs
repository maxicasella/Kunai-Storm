using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Invocacion : MonoBehaviour
{
    public GameObject soldiersA;
    public GameObject soldiersB;
    public float timeToNext;
    public float baseTime;
    public Transform spawnerA;
    public Transform spawnerB;
    public int soldiersSpawn=0;
    Animator necromancer;
    private int spawn;

    void Start()
    {
        necromancer = GetComponent<Animator>();
    }

    void Update()
    {

        timeToNext = timeToNext - timeToNext* Time.deltaTime;

        if(timeToNext<=0.1f)
        {
            if (soldiersSpawn < 8)
            {
                spawn = Random.Range(0, 2);
                if (spawn == 0)
                {
                    SpawnerA();
                }
                else
                {
                    SpawnerB();
                }

            }

            timeToNext = baseTime;
        }
       
    }



    public void SpawnerA()
    {
        
        necromancer.SetTrigger("Invocacion");
        GameObject soldierPrefab = Instantiate(soldiersA, spawnerA.position, Quaternion.identity);
        soldiersSpawn = soldiersSpawn + 1;
        necromancer.SetBool("Iddle", true);
        
                       
    }
    public void SpawnerB()
    {
        necromancer.SetTrigger("Invocacion");
        GameObject soldierPrefab = Instantiate(soldiersB, spawnerB.position, Quaternion.identity);
        soldiersSpawn = soldiersSpawn + 1;
        necromancer.SetBool("Iddle", true);
        
    }
               
        
}

   


