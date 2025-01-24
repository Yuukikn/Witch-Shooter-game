using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waveControl : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI waveCount;

    // Update is called once per frame
    private void Update()
    {
        waveStart();
        waveEnd();

        if(global.waveStart == true)
        {
            global.waveEnd = false;
            global.waveStart = false;
        }
    }

    private void waveStart()
    {

        if(global.waveEnd == true)
        {
            global.waveDelay += 0.01f;

                if(global.waveDelay >= 5)
                {
                    global.wave += 1;
                    global.waveDelay = 0;
                    global.waveNumber += 1;
                    waveCount.text = "Wave: " + global.waveNumber;
                    global.enamyNumber = 10 * global.waveNumber;
                    global.catNumber = global.waveNumber - 1; 
                    global.waveStart = true;
                }

        }

    }

    private void waveEnd()
    {
        if(global.enamyNumber <= 0)
        {
            if(GameObject.FindGameObjectWithTag("enamy") == null && global.bossRound == false)
            {
                global.spawnTimer1 = 0;
                global.spawnTimer2 = 0;
                global.spawnTimer3 = 0;
                global.spawnTimer4 = 0;
                global.catSpawnTimer = 0;
                global.waveEnd = true;
                global.bossCount = 1;
            }
        }
        
        if(global.bossRound == true)
        {
            if(GameObject.FindGameObjectWithTag("boss") == null)
            {
                global.bossRound = false;
                global.waveEnd = true;
                global.bossDestroyed = true;
            }
        }
    }
}
