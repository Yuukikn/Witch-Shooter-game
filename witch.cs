using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class witch : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private Transform projectile;
    [SerializeField]private Transform shootPosition;
    [SerializeField]private Image[] hearts;

    float shootDelay = 5;
    float shootTimer = 0;
    float invincableTimer = 0;
    float invincableEnd = 5;
    float speed = 15;

    int hp = 5;

    bool isInvincable = false;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(global.gameStart == true)
        {
            hitPoints();
    
            int hitLayer = LayerMask.NameToLayer("player");
            if(isInvincable == true)
            {
                invincableTimer += 0.01f;
            }
        

            if(invincableTimer >= invincableEnd)
            {
                gameObject.layer = hitLayer;
                isInvincable = false;
                invincableTimer = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        if(global.gameStart == true)
        {
            movement();
            shoot();
        }      
    }

    private void movement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, 0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, 0);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, speed, 0);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, -speed, 0);
        }

        if(Input.anyKey == false)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

    }

    private void shoot()
    {
        shootTimer += 0.6f;
        
        if(shootTimer >= shootDelay)
        {
            projectile.position = new Vector3(shootPosition.position.x + 1, shootPosition.position.y, 0);
            Instantiate(projectile);
            shootTimer = 0;
        }
    }

    private void hitPoints()
    {

        if(hp == 5)
        {
            hearts[0].enabled = true;
            hearts[1].enabled = true;
            hearts[2].enabled = true;
            hearts[3].enabled = true;
            hearts[4].enabled = true;
        }
        
        if(hp == 4)
        {
            hearts[0].enabled = true;
            hearts[1].enabled = true;
            hearts[2].enabled = true;
            hearts[3].enabled = true;
            hearts[4].enabled = false;
        }

        if(hp == 3)
        {
            hearts[0].enabled = true;
            hearts[1].enabled = true;
            hearts[2].enabled = true;
            hearts[3].enabled = false;
        }

        if(hp == 2)
        {
            hearts[0].enabled = true;
            hearts[1].enabled = true;
            hearts[2].enabled = false;
        }

        if(hp == 1)
        {
            hearts[0].enabled = true;
            hearts[1].enabled = false;
        }

        if(hp == 0)
        {
            hearts[0].enabled = false;
            global.gameOver = true;
            global.gameStart = false;
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enamy" || collision.gameObject.tag == "boss")
        {
            int invincable = LayerMask.NameToLayer("invincable");
            hp -= 1;
            gameObject.layer = invincable;
            isInvincable = true;
        }

        if(collision.gameObject.tag == "metalBall")
        {
            int invincable = LayerMask.NameToLayer("invincable");
            hp -= 1;
            gameObject.layer = invincable;
            isInvincable = true;
        }
        
        if(collision.gameObject.name == "bossGhost(Clone)")
        {
            hp = 0;
        }
    }

}
