using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class catSpawn : MonoBehaviour
{
    [SerializeField] private GameObject catSpawn1;
    [SerializeField] private GameObject catSpawn2;
    [SerializeField] private GameObject catSpawn3;
    [SerializeField] private GameObject catSpawn4;
    [SerializeField] private GameObject catSpawn5;
    [SerializeField] private GameObject catSpawn6;
    [SerializeField] private GameObject catSpawn7;
    [SerializeField] private GameObject catSpawn8;
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject metalBall1;
    [SerializeField] private GameObject metalBall2;
    [SerializeField] private GameObject metalBall3;
    [SerializeField] private GameObject metalBall4;
    [SerializeField] private GameObject metalBall5;
    [SerializeField] private GameObject metalBall6;
    [SerializeField] private GameObject metalBall7;
    [SerializeField] private GameObject metalBall8;

    private Random spawnPosition = new Random();

    private bool spawn1Active = true;
    private bool spawn2Active = true;
    private bool spawn3Active = true;
    private bool spawn4Active = true;
    private bool spawn5Active = true;    
    private bool spawn6Active = true;
    private bool spawn7Active = true;    
    private bool spawn8Active = true; 

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {

        if(global.gameStart == true)
        {
            global.catSpawnTimer += 0.01f;
            
            wave2();
        }
        
    }

    private void wave2()
    {
        if(global.catNumber >= 1)
        {
            if(global.catSpawnTimer >= 6 && global.catSpawnTimer  <= 6.01)
            {
                if(spawnPosition.Next(0, 100) <= 12.5 && spawn2Active == true ) 
                {
                    cat.transform.position = catSpawn2.transform.position;
                    Instantiate(cat).gameObject.tag="cat2";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn2Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 25 && spawn3Active == true)
                {
                    cat.transform.position = catSpawn3.transform.position;
                    Instantiate(cat).gameObject.tag="cat3";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn3Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 37.5 && spawn4Active == true)
                {
                    cat.transform.position = catSpawn4.transform.position;
                    Instantiate(cat).gameObject.tag="cat4";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn4Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 50 && spawn5Active == true)
                {
                    cat.transform.position = catSpawn5.transform.position;
                    Instantiate(cat).gameObject.tag="cat5";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn5Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 62.5 && spawn6Active == true)
                {
                    cat.transform.position = catSpawn6.transform.position;
                    Instantiate(cat).gameObject.tag="cat6";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn6Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 75 && spawn7Active == true)
                {
                    cat.transform.position = catSpawn7.transform.position;
                    Instantiate(cat).gameObject.tag="cat7";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn7Active = false;
                }

                else if(spawnPosition.Next(0, 100) <= 87.5 && spawn8Active == true)
                {
                    cat.transform.position = catSpawn8.transform.position;
                    Instantiate(cat).gameObject.tag="cat8";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn8Active = false;

                }

                else if(spawn1Active == true)
                {
                    cat.transform.position = catSpawn1.transform.position;
                    Instantiate(cat).gameObject.tag="cat1";
                    global.catNumber -= 1;
                    global.catSpawnTimer = 0;
                    spawn1Active = false;
                }

                spawnActive();
            }
        }
    }

    private void spawnActive()
        {
            if(GameObject.FindGameObjectWithTag("cat1") == null)
            {
                spawn1Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat2") == null)
            {
                spawn2Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat3") == null)
            {
                spawn3Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat4") == null)
            {
                spawn4Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat5") == null)
            {
                spawn5Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat6") == null)
            {
                spawn6Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat7") == null)
            {
                spawn7Active = true;
            }

            if(GameObject.FindGameObjectWithTag("cat8") == null)
            {
                spawn8Active = true;
            }
        }
}
