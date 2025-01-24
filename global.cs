using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour
{
    public static float spawnTimer1 = 0;
    public static float spawnTimer2 = 0;
    public static float spawnTimer3 = 0;
    public static float spawnTimer4 = 0;
    public static float catSpawnTimer = 0;
    public static float waveDelay = 0;
    public static int waveNumber = 1;
    public static int enamyNumber = 30;
    public static int catNumber  = 0;
    public static int wave = 1;
    public static int bossCount = 1;
    public static bool waveEnd = false;
    public static bool waveStart = false;
    public static bool gameOver = false;
    public static bool gameStart = true;
    public static bool startPressed = false;
    public static bool bossRound = false;
    public static bool bossDestroyed = false; 
}
