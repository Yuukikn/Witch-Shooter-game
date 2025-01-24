using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class bossGhost: MonoBehaviour
{
    private Rigidbody2D rb;

    int hp = 30;

    float speed = 2;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        rb.velocity = new Vector3(-speed, 0, 0);

        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall" ) 
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "player projectile")
        {
            hp -= 1;
        }
    }
}
