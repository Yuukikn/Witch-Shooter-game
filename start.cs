using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

    private float timer = 0f;

    [SerializeField] private TextMeshProUGUI startGame;
    [SerializeField] private Button button;


    private void Start()
    {
        startGame.enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer <= 1.3f)
        {
            startGame.enabled = true;
        }

        if(timer >= 1.4f)
        {
            startGame.enabled = false;
        }

        if(timer >= 2f)
        {
            timer = 0; 
        }

            if(GameObject.FindGameObjectWithTag("witch") == null)
            {
                global.spawnTimer1 = 0;
                global.spawnTimer2 = 0;
                global.spawnTimer3 = 0;
                global.spawnTimer4 = 0;
                global.catSpawnTimer = 0;
                global.waveDelay = 0;
                global.waveNumber = 1;
                global.enamyNumber = 10;
                global.catNumber = 0;
                global.wave = 0;
                global.waveEnd = false;
                global.waveStart = false;
                global.gameOver = false;
                global.gameStart = true;
                global.startPressed = false;
                global.wave = +1;
                StartCoroutine(LoadYourAsyncScene());
            }
            
        
    }

    private void OnEnable()
    {
        //Register Button Events
        button.onClick.AddListener(() => buttonCallBack(button));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if(buttonPressed == button)
        {
            global.gameStart = true;
            global.startPressed = true;
        }
    } 
        

    private IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene"); 

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    
    //all global veribles arnt being re set after each game start  
        
}
