using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointTop1 : MonoBehaviour
{
    [SerializeField] private Transform ghost;
     
    
    // Start is called before the first frame update
    private void Start()
    {

        
    }

    // Update is called once per frame
    private void Update()
    {
        if(global.gameStart == true)
        {
            ghost.position = transform.position;
            global.spawnTimer1 += 0.01f;

       

            if(global.wave == 1)
            {
                wave1();
            }
        }
        
    }

        private void wave1()
        {

            if(global.spawnTimer1  >= 6 && global.spawnTimer1  <= 6.01)
            {
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer1 >= 14 && global.spawnTimer1  <= 14.01f)
            {
                if(global.enamyNumber >= 1)
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer1 >= 16 && global.spawnTimer1  <= 16.01f)
            {
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost);
                    global.spawnTimer1 = 0;
                    global.enamyNumber -= 1;
                }
            }
        }

    
}
