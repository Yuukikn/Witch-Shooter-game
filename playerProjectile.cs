using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerProjectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    private Transform witch;

    float speed = 40;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("witch");
        witch = player.GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall" || collision.gameObject.tag == "enamy" || collision.gameObject.tag == "boss")
        {
            Destroy(this.gameObject);
        }

        
    }

}
