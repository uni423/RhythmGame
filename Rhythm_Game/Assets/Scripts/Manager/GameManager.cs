using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    //매니져 스크립트 선언

    public bool IsGamePlay = false;

    public int score = 0;
    public int DeadMonsters = 0;

    public void Ingame_Init()
    {
        Debug.Log("GameManager Init Start");

        if (SceneManager.GetActiveScene().name == "02_Ingame")
        {
            //매니져 스크립트 할당 및 Init

            IsGamePlay = true;
        }
    }
}