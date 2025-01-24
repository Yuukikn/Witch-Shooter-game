using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Animator anim;
    private enum State {idel, jump};
    private State state = State.jump;
    private Rigidbody2D rb;

    public static bool cat1Hit = false;
    public static bool cat2Hit = false;
    public static bool cat3Hit = false;
    public static bool cat4Hit = false;
    public static bool cat5Hit = false;
    public static bool cat6Hit = false;
    public static bool cat7Hit = false;
    public static bool cat8Hit = false;
    
    bool leave = false;
    bool enter = true;
    float speed = 5;
    float timer = 0;
    int layerMask = 1 << 6;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        anim.SetInteger("state", (int)state);
        animationState();

        if(enter == true  && leave == false)
        {
            rb.velocity = new Vector3(-1, speed, 0);
            if(rb.position.y >= -3.45)
            {
                rb.velocity = new Vector3(0, 0, 0);
                timer += 0.1f;
                if(timer >= 1.5)
                {
                    enter = false;
                    timer = 0;
                }
                
            }
        }

        if(enter == false)
        {
            pathCrossed();
        }

        if(global.waveEnd == true)
        {
           rb.velocity = new Vector3(-1, -speed, 0);
        }



    }

    private void animationState()
    {
        if(enter == false && leave == false)
        {
            state = State.idel;
        }

        if(enter == true || leave == true || global.waveEnd == true)
        {
            state = State.jump;
        }
    }

    private void pathCrossed()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 100, layerMask);

        if(hit.collider != null)
        {
            if(this.gameObject.tag == "cat1")
            {
                cat1Hit = true;
                enter = true;
            }

            if(this.gameObject.tag == "cat2")
            {
                cat2Hit = true;
                enter = true;
            }

            if(this.gameObject.tag == "cat3")
            {
                cat3Hit = true;
                enter = true;
            }

            if(this.gameObject.tag == "cat4")
            {
                cat4Hit = true;
                enter = true;
            }

            if(this.gameObject.tag == "cat5")
            {
                cat5Hit = true;
                enter = true;
            }

            if(this.gameObject.tag == "cat6")
            {
                cat6Hit = true;
                enter = true;       
            }

            if(this.gameObject.tag == "cat7")
            {
                cat7Hit = true;
                enter = true; 
            }

            if(this.gameObject.tag == "cat8")
            {
                cat8Hit = true;
                enter = true; 
            }


            rb.velocity = new Vector3(-1, -speed, 0);
            leave = true;
        }

    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "underWall" ) 
        {
            Destroy(this.gameObject);
        }
    }

}
