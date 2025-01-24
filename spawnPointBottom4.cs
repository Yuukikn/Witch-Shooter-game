using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointBottom4 : MonoBehaviour
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
            global.spawnTimer4 += 0.01f;

            if(global.wave == 1)
            {
                wave1();
            }
        }    
        
    }

        private void wave1()
        {

            if(global.spawnTimer4  >= 10 && global.spawnTimer4  <= 10.01)
            {
                
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer4 >= 20 && global.spawnTimer4  <= 20.01f)
            {
                if(global.enamyNumber >= 1)
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }
        
        }
}
