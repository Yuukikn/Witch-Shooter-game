using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class enamySpawns : MonoBehaviour
{

    [SerializeField]private GameObject ghost;
    [SerializeField]private GameObject spawn1;
    [SerializeField]private GameObject spawn2;
    [SerializeField]private GameObject spawn3;
    [SerializeField]private GameObject spawn4;
    [SerializeField]private GameObject bossGhost;
    [SerializeField]private GameObject ghostBossSpawn;
    
    private Random rnd = new Random();


    float timer1 = 0;
    float timer2 = 0;
    float timer3 = 0;
    float timer4 = 0;

    int randNumber;

    private void Update()
    { 
        if(global.gameStart == true)
        {
            randomGen();
            ghostBoss();
        }
    }

    private void randomGen()
    {
        if(global.enamyNumber >= 0)
        {


            if(global.waveNumber != 3 && global.waveNumber != 6 && global.waveNumber != 9 && global.waveNumber != 12 && global.waveNumber != 15   )
            {
                int spawnPosition = rnd.Next(1,5);
                if(spawnPosition == 1)
                {
                    timer1 += Time.deltaTime;
                    if(timer1 >= 0.5)
                    {
                        ghost.transform.position = spawn1.transform.position;
                        Instantiate(ghost);
                        global.enamyNumber -= 1;
                        timer1 = 0;
                    }
                }

                if(spawnPosition == 2)
                {
                    timer2 += Time.deltaTime;
                    if(timer2 >= 0.5)
                    {
                        ghost.transform.position = spawn2.transform.position;
                        Instantiate(ghost);
                        global.enamyNumber -= 1;
                        timer2 = 0;
                    }  
                }

                if(spawnPosition == 3)
                {
                    timer3 += Time.deltaTime;
                    if(timer3 >= 0.5)
                    {
                        ghost.transform.position = spawn3.transform.position;
                        Instantiate(ghost);
                        global.enamyNumber -= 1;
                        timer3 = 0;
                    }
                }

                if(spawnPosition == 4)
                {
                    timer4 += Time.deltaTime;
                    if(timer4 >= 0.5)
                    {
                        ghost.transform.position = spawn4.transform.position;
                        Instantiate(ghost);
                        global.enamyNumber -= 1;
                        timer4 = 0;
                    }
                }
            }
        }  
    }

    private void ghostBoss()
    {
        int spawnPosition = rnd.Next(1,5);
        if(global.waveNumber == 3)
        {
            global.bossRound = true;
            if(global.bossCount == 1)
            {
                bossGhost.transform.position = ghostBossSpawn.transform.position;
                Instantiate(bossGhost);
                global.bossCount -= 1;
            }
            if(spawnPosition == 1)
            {
                timer1 += Time.deltaTime;
                if(timer1 >= 0.5)
                {
                    ghost.transform.position = spawn1.transform.position;
                    Instantiate(ghost);
                    timer1 = 0;
                }
            }

            if(spawnPosition == 2)
            {
                timer2 += Time.deltaTime;
                if(timer2 >= 0.5)
                {
                    ghost.transform.position = spawn2.transform.position;
                    Instantiate(ghost);
                    timer2 = 0;
                }  
            }

            if(spawnPosition == 3)
            {
                timer3 += Time.deltaTime;
                if(timer3 >= 0.5)
                {
                    ghost.transform.position = spawn3.transform.position;
                    Instantiate(ghost);
                    timer3 = 0;
                }
            }

            if(spawnPosition == 4)
            {
                timer4 += Time.deltaTime;
                if(timer4 >= 0.5)
                {
                    ghost.transform.position = spawn4.transform.position;
                    Instantiate(ghost);
                    timer4 = 0;
                }
            }
        }
    }

}
