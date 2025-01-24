using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metalBallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject metalBall;
    [SerializeField] private GameObject spawn1;
    [SerializeField] private GameObject spawn2;
    [SerializeField] private GameObject spawn3;
    [SerializeField] private GameObject spawn4;
    [SerializeField] private GameObject spawn5;
    [SerializeField] private GameObject spawn6;
    [SerializeField] private GameObject spawn7;
    [SerializeField] private GameObject spawn8;

    public static bool metalBallSpawn1Active = true;
    public static bool metalBallSpawn2Active = true;
    public static bool metalBallSpawn3Active = true;
    public static bool metalBallSpawn4Active = true;
    public static bool metalBallSpawn5Active = true;    
    public static bool metalBallSpawn6Active = true;
    public static bool metalBallSpawn7Active = true;    
    public static bool metalBallSpawn8Active = true;

    float timer1 = 0;
    float timer2 = 0;
    float timer3 = 0;
    float timer4 = 0;
    float timer5 = 0;
    float timer6 = 0;
    float timer7 = 0;
    float timer8 = 0;


    private void Start()
    {
    }


    

    private void Update()
    {

    if(metalBallSpawn1Active == false)
    {
        timer1 += 0.01f;

        if(timer1 >= 10f)
        {
            metalBallSpawn1Active = true;
            timer1 = 0;
        }
    }

    if(metalBallSpawn2Active == false)
    {
        timer2 += 0.01f;
         
        if(timer2 >= 10f)
        {
            metalBallSpawn2Active = true;
            timer2 = 0;
        }
    }

    if(metalBallSpawn3Active == false)
    {
        timer3 += 0.01f;
         
        if(timer3 >= 10f)
        {
            metalBallSpawn3Active = true;
            timer3 = 0;
        }
    }

    if(metalBallSpawn4Active == false)
    {
        timer4 += 0.01f;
         
        if(timer4 >= 10f)
        {
            metalBallSpawn4Active = true;
            timer4 = 0;
        }
    }

    if(metalBallSpawn5Active == false)
    {
        timer5 += 0.01f;
         
        if(timer5 >= 2)
        {
            metalBallSpawn5Active = true;
            timer5 = 0;
        }
    }

    if(metalBallSpawn6Active == false)
    {
        timer6 += 0.01f;
         
        if(timer6 >= 10f)
        {
            metalBallSpawn6Active = true;
            timer6 = 0;
        }
    }

    if(metalBallSpawn7Active == false)
    {
        timer7 += 0.01f;
         
        if(timer7 >= 10f)
        {
            metalBallSpawn7Active = true;
            timer7 = 0;
        }
    }
    
    if(metalBallSpawn8Active == false)
    {
        timer8 += 0.01f;
         
        if(timer8 >= 10f)
        {
            metalBallSpawn8Active = true;
            timer8 = 0;
        }
    }

        if(metalBallSpawn1Active == true && cat.cat1Hit == true)
        {
            metalBall.transform.position = spawn1.transform.position;
            Instantiate(metalBall);
            metalBallSpawn1Active = false;
            cat.cat1Hit = false;
        }

        else if(metalBallSpawn2Active == true && cat.cat2Hit == true)
        {
            metalBall.transform.position = spawn2.transform.position;
            Instantiate(metalBall);
            metalBallSpawn2Active = false;
            cat.cat2Hit = false;
        }

        else if(metalBallSpawn3Active == true && cat.cat3Hit == true)
        {
            metalBall.transform.position = spawn3.transform.position;
            Instantiate(metalBall);
            metalBallSpawn3Active = false;
            cat.cat3Hit = false;
        }  

        else if(metalBallSpawn4Active == true && cat.cat4Hit == true)
        {
            metalBall.transform.position = spawn4.transform.position;
            Instantiate(metalBall);
            metalBallSpawn4Active = false;
            cat.cat4Hit = false;
        }  

        else if(metalBallSpawn5Active == true && cat.cat5Hit == true)
        {
            metalBall.transform.position = spawn5.transform.position;
            Instantiate(metalBall);
            metalBallSpawn5Active = false;
            cat.cat5Hit = false;
        }

        else if(metalBallSpawn6Active == true && cat.cat6Hit == true)
        {
            metalBall.transform.position = spawn6.transform.position;
            Instantiate(metalBall);
            metalBallSpawn6Active = false;
            cat.cat6Hit = false;
        }

        else if(metalBallSpawn7Active == true && cat.cat7Hit == true)
        {
            metalBall.transform.position = spawn7.transform.position;
            Instantiate(metalBall);
            metalBallSpawn7Active = false;
            cat.cat7Hit = false;
        }

        else if(metalBallSpawn8Active == true && cat.cat8Hit == true)
        {
            metalBall.transform.position = spawn8.transform.position;
            Instantiate(metalBall);
            metalBallSpawn8Active = false;
            cat.cat8Hit = false;
        }
    }
}