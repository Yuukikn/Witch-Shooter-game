using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metalBall : MonoBehaviour
{

    int speed = -10;

    private Rigidbody2D rb;
    private CircleCollider2D col;
    private CharacterController colider;
    private Transform tran;

    private void Start()
    {
        col = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        colider = GetComponent<CharacterController>();
        tran = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "underWall")
        {
            Destroy(this.gameObject);
        }
    }

}
