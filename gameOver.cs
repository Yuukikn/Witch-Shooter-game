using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    private float timer = 0f;

    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private Button button;


    private void Start()
    {
        gameOverText.enabled = false;
    }

    private void Update()
    {
        if(global.gameOver == true)
        {
            timer += Time.deltaTime;

            if(timer <= 1.3f)
            {
                gameOverText.enabled = true;
            }

            if(timer >= 1.4f)
            {
                gameOverText.enabled = false;
            }

            if(timer >= 2f)
            {
                timer = 0; 
            }
            
        }
        
    }

    private void OnEnable()
    {
        //Register Button Events
        button.onClick.AddListener(() => buttonCallBack(button));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if(global.gameOver == true)
        {
            if(buttonPressed == button)
            {
                global.gameOver = false;
                global.startPressed = false;
                StartCoroutine(LoadYourAsyncScene());;
            }
        }
    }

    
    private IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("StartScreen"); 

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
