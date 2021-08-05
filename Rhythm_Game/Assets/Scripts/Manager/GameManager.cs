using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    //매니져 스크립트 선언
    public NodeManager nodeMng;

    public bool IsGamePlay = false;

    public int WH;
    public int Bpm = 100;

    public int score = 0;

    public void Start()
    //public void Init()
    {
        Debug.Log("GameManager Init Start");

        if (SceneManager.GetActiveScene().name == "02_Ingame")
        {
            if (WH % 2 == 0) 
                WH += 1;

            //매니져 스크립트 할당 및 Init
            nodeMng = GameObject.FindObjectOfType<NodeManager>();
            nodeMng.Init();

            IsGamePlay = true;
        }

        Debug.Log("GameManager Init Clear");
    }
}