using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreenWitch : MonoBehaviour
{
    private Rigidbody2D rb;

    private float speed = 10f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(global.startPressed == true)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
