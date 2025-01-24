using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointTopMide2 : MonoBehaviour
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
            global.spawnTimer2 += 0.01f;

       
    
            if(global.wave == 1)
            {
                wave1();
            }
        }
        
    }

        private void wave1()
        {

            if(global.spawnTimer2  >= 10 && global.spawnTimer2  <= 10.01)
            {
                
                if(global.enamyNumber >= 1 )
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }

            if(global.spawnTimer2 >= 20 && global.spawnTimer2  <= 20.01f)
            {
                if(global.enamyNumber >= 1)
                {
                    Instantiate(ghost);
                    global.enamyNumber -= 1;
                }
            }

        }
}
