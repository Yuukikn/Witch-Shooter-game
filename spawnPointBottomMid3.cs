using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointBottomMid3 : MonoBehaviour
{
    [SerializeField] private Transform ghost3;
    // Start is called before the first frame update



    
    void Start ()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        
        if(global.gameStart == true)
        {
            ghost3.position = transform.position;
            global.spawnTimer3 += 0.01f;


            if(global.wave == 1)
            {
                wave1();
            }
        }    
        
    }

        private void wave1()
        {

            if(global.spawnTimer3  >= 6 && global.spawnTimer3  <= 6.01) 
            {
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost3);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer3 >= 14 && global.spawnTimer3 <= 14.01f)
            {
                if(global.enamyNumber >= 1)
                {
                    Instantiate(ghost3);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer3 >= 16 && global.spawnTimer3  <= 16.01f)
            {
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost3);
                    global.spawnTimer3 = 0;
                    global.enamyNumber -= 1;
                }
            }
        
        }

}
